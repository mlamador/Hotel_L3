using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reservas
{
    public class HabitacionesBL
    {
        Contexto _contexto;

        public BindingList<Habitaciones> listaHabitaciones { get; set; }

        public HabitacionesBL()
        {
            _contexto = new Contexto();

            listaHabitaciones = new BindingList<Habitaciones>();

        }

        public BindingList<Habitaciones> ObtenerHabitaciones()
        {

            _contexto.habitacion.Load();
            listaHabitaciones = _contexto.habitacion.Local.ToBindingList();

            return listaHabitaciones;
        }


        //GUARDAR


        public Resultado GuardarHabitaciones(Habitaciones habitacion)
        {
            var resultado = Validar(habitacion);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (habitacion.Id == 0)
            {
                habitacion.Id = listaHabitaciones.Max(item => item.Id) + 1;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }


        //AGREGAR


        public void AgregarHabitaciones()
        {
            var nuevoHabitaciones = new Habitaciones();
            listaHabitaciones.Add(nuevoHabitaciones);

        }


        //ELIMINAR


        public bool ElimarHabitaciones(int id)
        {
            foreach (var habitacion in listaHabitaciones)
            {
                if (habitacion.Id == id)
                {
                    listaHabitaciones.Remove(habitacion);
                    return true;
                }
            }

            _contexto.SaveChanges();
            return false;
        }
        private Resultado Validar(Habitaciones habitacion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (habitacion == null)
            {
                resultado.Mensaje = "Agregue un producto valido";
                resultado.Exitoso = false;
                return resultado;
            }

            if (habitacion.TipoId == 0)
            {
                resultado.Mensaje = "Ingrese Tipo de Habitacion";
                resultado.Exitoso = false;
            }


            if (string.IsNullOrEmpty(habitacion.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (habitacion.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
        }


        //Cancelar

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }

            _contexto.SaveChanges();

        }


        //Buscar
        public BindingList<Habitaciones> ObtenerHabitaciones(string buscar)
        {
            var query = _contexto.habitacion
                .Where(p => p.Descripcion.ToLower()
                    .Contains(buscar.ToLower()) == true)
                        .ToList();

            var resultado = new BindingList<Habitaciones>(query);

            return resultado;
        }

    }


    public class Habitaciones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoH { get; set; }
        public double Precio { get; set; }
        public bool Efectivo { get; set; }
        public bool Tarjeta { get; set; }
        public string Descripcion { get; set; }

        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}












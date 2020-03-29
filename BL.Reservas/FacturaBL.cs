using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reservas
{
    public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> listaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();

            listaFacturas = new BindingList<Factura>();
        }

        public BindingList<Factura> ObtenerFacturas()
        {

            _contexto.factura.Include("FacturaDetalle").Load();
            listaFacturas = _contexto.factura.Local.ToBindingList();

            return listaFacturas;
        }

        public void AgregarFacturas()
        {
            var nuevoFactura = new Factura();
            listaFacturas.Add(nuevoFactura);
        }
        public void AgregarFacturaDetalle(Factura factura)
        {
            if(factura !=null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }
        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle)
        {
            if(factura != null && facturaDetalle != null)
            {
                factura.FacturaDetalle.Remove(facturaDetalle);
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarFactura(Factura factura)
        {   
            var resultado = Validar(factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if(factura == null)
            {
                resultado.Mensaje = "Agregar para poderla salvar";
                resultado.Exitoso = false;
                return resultado;
            }

            if (factura.Id!=0 && factura.Activo == true) //...?
            {
                resultado.Mensaje = "La factura ya fue emitida y o se puede realsar cambios en ella";
                resultado.Exitoso = false;

            }


            if (factura.Activo == false) //...?
                     {
                         resultado.Mensaje = "La factura esta anulada y no se puede guardar";
                         resultado.Exitoso = false;

                     }
            if (factura.ClienteId == 0)
            {
                resultado.Mensaje = "Seleccione un cliente";
                resultado.Exitoso = false;

            }
            if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue productos a la factura";
                resultado.Exitoso = false;

            }

            foreach (var detalle in factura.FacturaDetalle)
            {
                if (detalle.HabitacionId ==0)
                {
                    resultado.Mensaje = "Seleccione productos validos";
                }
            }

            return resultado;
        }
        public void CalcularFactura(Factura factura)
        {
            if(factura !=null)
            {
                double subtotal = 0;

                foreach (var detalle in factura.FacturaDetalle)
                {
                    var habitaciones = _contexto.habitacion.Find(detalle.HabitacionId);
                    if(habitaciones != null)
                    {
                        detalle.Precio = habitaciones.Precio;
                        detalle.Total = habitaciones.Precio;

                        subtotal += detalle.Total;
                    }
                }
                factura.Subtotal = subtotal;//...?
                factura.Total = subtotal;
            }
        }

        public bool AnularFactura(int id)//...
        {
            foreach (var factura in listaFacturas)
            {
                if (factura.Id == id)
                {
                    factura.Activo = false;
                    _contexto.SaveChanges();
                    return true;

                }
            }

            return false;

        }

       }
        public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }

    }
    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int HabitacionId { get; set; }
        public Habitaciones Habitaciones { get; set; }        
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {

        }
    }

}

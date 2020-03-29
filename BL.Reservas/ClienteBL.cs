using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reservas
{
    public class ClienteBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClienteBL()
        {
            ListaClientes = new BindingList<Cliente>();
        }

        //OBTENER

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }
        //GUARDAR
        public Resultad GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            if(cliente.Id == 0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true; 
            return resultado;
        }
        //AGREGAR
        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }
        //ELIMINAR

        public bool EliminarCliente(int id)
        {
            foreach (var cliente  in ListaClientes)
            {
                if(cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);

                    return true;
                }
            }
            return false;
        }

        //VALIDACION
        
        private Resultad Validar(Cliente cliente)
        {
            var resultado = new Resultad();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un cliente valido";
                resultado.Exitoso = false;
                return resultado;
            }//...


            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultad
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

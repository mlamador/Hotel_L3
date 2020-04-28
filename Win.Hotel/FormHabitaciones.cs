using BL.Reservas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Hotel
{
    public partial class FormHabitaciones : Form
    {
        HabitacionesBL _habitaciones;
        TiposBL _tiposBL;

        public FormHabitaciones()
        {
            InitializeComponent();

            _habitaciones = new HabitacionesBL();
            listaHabitacionesBindingSource.DataSource = _habitaciones.ObtenerHabitaciones();

            _tiposBL = new TiposBL();
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void listaHabitacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaHabitacionesBindingSource.EndEdit();
            var habitacion = (Habitaciones)listaHabitacionesBindingSource.Current;

            var resultado = _habitaciones.GuardarHabitaciones(habitacion);
            if (resultado.Exitoso == true)
            {
                listaHabitacionesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _habitaciones.AgregarHabitaciones();
            listaHabitacionesBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _habitaciones.ElimarHabitaciones(id);

            if (resultado == true)
            {
                listaHabitacionesBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Öcurrio un error al eliminar una habitacion");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _habitaciones.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            // Eliminar(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buscar = textBox1.Text;

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaHabitacionesBindingSource.DataSource =
                    _habitaciones.ObtenerHabitaciones();
            }
            else
            {
                listaHabitacionesBindingSource.DataSource =
                    _habitaciones.ObtenerHabitaciones(buscar);
            }


            listaHabitacionesBindingSource.ResetBindings(false);
        }
    }
}

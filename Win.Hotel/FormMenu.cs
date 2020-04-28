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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: "
                    + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Recepcion")
                {
                    habitacionesToolStripMenuItem.Visible = true;
                    clienteToolStripMenuItem.Visible = true;
                    rentasToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    usuarioToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;
                    reporteDeRentasToolStripMenuItem.Visible = true;
                    reportesDeFacturasToolStripMenuItem.Visible = false;
                    reporteDeHabitacionesToolStripMenuItem.Visible = false;

                }

                if (Program.UsuarioLogueado.TipoUsuario == "Administrador")
                {
                    habitacionesToolStripMenuItem.Visible = true;
                    clienteToolStripMenuItem.Visible = true;
                    rentasToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    usuarioToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                    reporteDeRentasToolStripMenuItem.Visible = true;
                    reportesDeFacturasToolStripMenuItem.Visible = true;
                    reporteDeHabitacionesToolStripMenuItem.Visible = true;
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHabitaciones = new FormHabitaciones();
            //formHabitaciones.MdiParent = this;
            formHabitaciones.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            //formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReservas = new FormReservas();
            formReservas.MdiParent = this;
            formReservas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteHabitaciones = new FormReportesHabitaciones();
            formReporteHabitaciones.MdiParent = this;
            formReporteHabitaciones.Show();
        }

        private void reportesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReportesFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUsuarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}

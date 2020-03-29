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
    }
}

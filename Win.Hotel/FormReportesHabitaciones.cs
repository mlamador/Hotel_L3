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
    public partial class FormReportesHabitaciones : Form
    {
        public FormReportesHabitaciones()
        {
            InitializeComponent();

            var _habitacionBl = new HabitacionesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _habitacionBl.ObtenerHabitaciones();

            var reporte = new ReporteHabitaciones();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}

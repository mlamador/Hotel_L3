﻿using BL.Reservas;
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

            var _habitacionBL = new HabitacionesBL();
            var _tiposBL = new TiposBL();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _habitacionBL.ObtenerHabitaciones();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _tiposBL.ObtenerTipos();

            var reporte = new ReporteHabitaciones();
            reporte.Database.Tables["Habitaciones"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Tipo"].SetDataSource(bindingSource2);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}

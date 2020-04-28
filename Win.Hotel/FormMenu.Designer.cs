namespace Win.Hotel
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.rentasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.rentasToolStripMenuItem.Text = "Reservaciones";
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeHabitacionesToolStripMenuItem,
            this.reporteDeClienteToolStripMenuItem,
            this.reporteDeRentasToolStripMenuItem,
            this.reportesDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeHabitacionesToolStripMenuItem
            // 
            this.reporteDeHabitacionesToolStripMenuItem.Name = "reporteDeHabitacionesToolStripMenuItem";
            this.reporteDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteDeHabitacionesToolStripMenuItem.Text = "Reporte de Habitaciones";
            this.reporteDeHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeHabitacionesToolStripMenuItem_Click);
            // 
            // reporteDeClienteToolStripMenuItem
            // 
            this.reporteDeClienteToolStripMenuItem.Name = "reporteDeClienteToolStripMenuItem";
            this.reporteDeClienteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteDeClienteToolStripMenuItem.Text = "Reporte de Cliente";
            // 
            // reporteDeRentasToolStripMenuItem
            // 
            this.reporteDeRentasToolStripMenuItem.Name = "reporteDeRentasToolStripMenuItem";
            this.reporteDeRentasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteDeRentasToolStripMenuItem.Text = "Reporte de Rentas";
            // 
            // reportesDeFacturasToolStripMenuItem
            // 
            this.reportesDeFacturasToolStripMenuItem.Name = "reportesDeFacturasToolStripMenuItem";
            this.reportesDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reportesDeFacturasToolStripMenuItem.Text = "Reportes de Facturas";
            this.reportesDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reportesDeFacturasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 378);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
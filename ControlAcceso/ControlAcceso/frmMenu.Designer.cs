namespace ControlAcceso
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosVisitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoVisitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasTrabajadasIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasTrabajadasGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llegadasTardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasPorDependenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasDeVisitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosEmpleadosToolStripMenuItem,
            this.registrosVisitantesToolStripMenuItem,
            this.ingresoEmpleadoToolStripMenuItem,
            this.ingresoVisitanteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "&Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // registrosEmpleadosToolStripMenuItem
            // 
            this.registrosEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrosEmpleadosToolStripMenuItem.Image")));
            this.registrosEmpleadosToolStripMenuItem.Name = "registrosEmpleadosToolStripMenuItem";
            this.registrosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrosEmpleadosToolStripMenuItem.Text = "Registro Empleados";
            this.registrosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.registrosEmpleadosToolStripMenuItem_Click);
            // 
            // registrosVisitantesToolStripMenuItem
            // 
            this.registrosVisitantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrosVisitantesToolStripMenuItem.Image")));
            this.registrosVisitantesToolStripMenuItem.Name = "registrosVisitantesToolStripMenuItem";
            this.registrosVisitantesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrosVisitantesToolStripMenuItem.Text = "Registro Visitantes";
            this.registrosVisitantesToolStripMenuItem.Click += new System.EventHandler(this.registrosVisitantesToolStripMenuItem_Click);
            // 
            // ingresoEmpleadoToolStripMenuItem
            // 
            this.ingresoEmpleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresoEmpleadoToolStripMenuItem.Image")));
            this.ingresoEmpleadoToolStripMenuItem.Name = "ingresoEmpleadoToolStripMenuItem";
            this.ingresoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresoEmpleadoToolStripMenuItem.Text = "Ingreso Empleado";
            this.ingresoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ingresoEmpleadoToolStripMenuItem_Click);
            // 
            // ingresoVisitanteToolStripMenuItem
            // 
            this.ingresoVisitanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresoVisitanteToolStripMenuItem.Image")));
            this.ingresoVisitanteToolStripMenuItem.Name = "ingresoVisitanteToolStripMenuItem";
            this.ingresoVisitanteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresoVisitanteToolStripMenuItem.Text = "Ingreso Visitante";
            this.ingresoVisitanteToolStripMenuItem.Click += new System.EventHandler(this.ingresoVisitanteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.dependenciasToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "&Parametros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // dependenciasToolStripMenuItem
            // 
            this.dependenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dependenciasToolStripMenuItem.Image")));
            this.dependenciasToolStripMenuItem.Name = "dependenciasToolStripMenuItem";
            this.dependenciasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dependenciasToolStripMenuItem.Text = "Dependencias";
            this.dependenciasToolStripMenuItem.Click += new System.EventHandler(this.dependenciasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horasTrabajadasIndividualToolStripMenuItem,
            this.horasTrabajadasGeneralToolStripMenuItem,
            this.llegadasTardeToolStripMenuItem,
            this.visitasPorDependenciaToolStripMenuItem,
            this.estadisticasDeVisitantesToolStripMenuItem,
            this.reporteDeEquiposToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // horasTrabajadasIndividualToolStripMenuItem
            // 
            this.horasTrabajadasIndividualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horasTrabajadasIndividualToolStripMenuItem.Image")));
            this.horasTrabajadasIndividualToolStripMenuItem.Name = "horasTrabajadasIndividualToolStripMenuItem";
            this.horasTrabajadasIndividualToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.horasTrabajadasIndividualToolStripMenuItem.Text = "Horas Trabajadas Individual";
            // 
            // horasTrabajadasGeneralToolStripMenuItem
            // 
            this.horasTrabajadasGeneralToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horasTrabajadasGeneralToolStripMenuItem.Image")));
            this.horasTrabajadasGeneralToolStripMenuItem.Name = "horasTrabajadasGeneralToolStripMenuItem";
            this.horasTrabajadasGeneralToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.horasTrabajadasGeneralToolStripMenuItem.Text = "Horas Trabajadas General";
            // 
            // llegadasTardeToolStripMenuItem
            // 
            this.llegadasTardeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("llegadasTardeToolStripMenuItem.Image")));
            this.llegadasTardeToolStripMenuItem.Name = "llegadasTardeToolStripMenuItem";
            this.llegadasTardeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.llegadasTardeToolStripMenuItem.Text = "Llegadas Tarde";
            // 
            // visitasPorDependenciaToolStripMenuItem
            // 
            this.visitasPorDependenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitasPorDependenciaToolStripMenuItem.Image")));
            this.visitasPorDependenciaToolStripMenuItem.Name = "visitasPorDependenciaToolStripMenuItem";
            this.visitasPorDependenciaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.visitasPorDependenciaToolStripMenuItem.Text = "Visitas por Dependencia";
            // 
            // estadisticasDeVisitantesToolStripMenuItem
            // 
            this.estadisticasDeVisitantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estadisticasDeVisitantesToolStripMenuItem.Image")));
            this.estadisticasDeVisitantesToolStripMenuItem.Name = "estadisticasDeVisitantesToolStripMenuItem";
            this.estadisticasDeVisitantesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.estadisticasDeVisitantesToolStripMenuItem.Text = "Estadisticas de visitantes";
            // 
            // reporteDeEquiposToolStripMenuItem
            // 
            this.reporteDeEquiposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeEquiposToolStripMenuItem.Image")));
            this.reporteDeEquiposToolStripMenuItem.Name = "reporteDeEquiposToolStripMenuItem";
            this.reporteDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.reporteDeEquiposToolStripMenuItem.Text = "Reporte de Equipos";
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeBDToolStripMenuItem,
            this.restaurarCopiaToolStripMenuItem});
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem1.Text = "&Seguridad";
            // 
            // copiaDeBDToolStripMenuItem
            // 
            this.copiaDeBDToolStripMenuItem.Name = "copiaDeBDToolStripMenuItem";
            this.copiaDeBDToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copiaDeBDToolStripMenuItem.Text = "Copia de BD";
            this.copiaDeBDToolStripMenuItem.Click += new System.EventHandler(this.copiaDeBDToolStripMenuItem_Click);
            // 
            // restaurarCopiaToolStripMenuItem
            // 
            this.restaurarCopiaToolStripMenuItem.Name = "restaurarCopiaToolStripMenuItem";
            this.restaurarCopiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.restaurarCopiaToolStripMenuItem.Text = "Restaurar Copia";
            this.restaurarCopiaToolStripMenuItem.Click += new System.EventHandler(this.restaurarCopiaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerda &de...";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 356);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Control de Acceso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosVisitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoVisitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasTrabajadasIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasTrabajadasGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llegadasTardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasPorDependenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasDeVisitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
    }
}
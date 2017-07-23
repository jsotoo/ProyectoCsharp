namespace ControlAcceso
{
    partial class frmRegistroEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEmpleados));
            this.BtNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtVolver = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtSiguiente = new System.Windows.Forms.Button();
            this.BtPrimero = new System.Windows.Forms.Button();
            this.BtUltimo = new System.Windows.Forms.Button();
            this.BtAnterior = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.catbdependenciasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controlAcceso1DataSet1 = new ControlAcceso.ControlAcceso1DataSet1();
            this.TbObs = new System.Windows.Forms.TextBox();
            this.TbCar = new System.Windows.Forms.TextBox();
            this.TbApe = new System.Windows.Forms.TextBox();
            this.TbNbr = new System.Windows.Forms.TextBox();
            this.TbDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.controlAcceso1DataSet = new ControlAcceso.ControlAcceso1DataSet();
            this.catbdependenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ca_tbdependenciasTableAdapter = new ControlAcceso.ControlAcceso1DataSetTableAdapters.ca_tbdependenciasTableAdapter();
            this.ca_tbdependenciasTableAdapter1 = new ControlAcceso.ControlAcceso1DataSet1TableAdapters.ca_tbdependenciasTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtNuevo
            // 
            this.BtNuevo.AccessibleName = "";
            this.BtNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtNuevo.Image")));
            this.BtNuevo.Location = new System.Drawing.Point(0, 2);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(67, 71);
            this.BtNuevo.TabIndex = 0;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtVolver);
            this.groupBox1.Controls.Add(this.BtBuscar);
            this.groupBox1.Controls.Add(this.BtSiguiente);
            this.groupBox1.Controls.Add(this.BtPrimero);
            this.groupBox1.Controls.Add(this.BtUltimo);
            this.groupBox1.Controls.Add(this.BtAnterior);
            this.groupBox1.Controls.Add(this.BtCancelar);
            this.groupBox1.Controls.Add(this.BtEliminar);
            this.groupBox1.Controls.Add(this.BtEditar);
            this.groupBox1.Controls.Add(this.BtGuardar);
            this.groupBox1.Controls.Add(this.BtNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtVolver
            // 
            this.BtVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtVolver.Image")));
            this.BtVolver.Location = new System.Drawing.Point(730, 2);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(67, 71);
            this.BtVolver.TabIndex = 11;
            this.BtVolver.Text = "Volver";
            this.BtVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtVolver.UseVisualStyleBackColor = true;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtBuscar.Image")));
            this.BtBuscar.Location = new System.Drawing.Point(657, 2);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(67, 71);
            this.BtBuscar.TabIndex = 10;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtSiguiente
            // 
            this.BtSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("BtSiguiente.Image")));
            this.BtSiguiente.Location = new System.Drawing.Point(584, 2);
            this.BtSiguiente.Name = "BtSiguiente";
            this.BtSiguiente.Size = new System.Drawing.Size(67, 71);
            this.BtSiguiente.TabIndex = 8;
            this.BtSiguiente.Text = "Siguiente";
            this.BtSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSiguiente.UseVisualStyleBackColor = true;
            this.BtSiguiente.Click += new System.EventHandler(this.BtSiguiente_Click);
            // 
            // BtPrimero
            // 
            this.BtPrimero.Image = ((System.Drawing.Image)(resources.GetObject("BtPrimero.Image")));
            this.BtPrimero.Location = new System.Drawing.Point(511, 2);
            this.BtPrimero.Name = "BtPrimero";
            this.BtPrimero.Size = new System.Drawing.Size(67, 71);
            this.BtPrimero.TabIndex = 7;
            this.BtPrimero.Text = "Primero";
            this.BtPrimero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPrimero.UseVisualStyleBackColor = true;
            this.BtPrimero.Click += new System.EventHandler(this.BtPrimero_Click);
            // 
            // BtUltimo
            // 
            this.BtUltimo.Image = ((System.Drawing.Image)(resources.GetObject("BtUltimo.Image")));
            this.BtUltimo.Location = new System.Drawing.Point(438, 2);
            this.BtUltimo.Name = "BtUltimo";
            this.BtUltimo.Size = new System.Drawing.Size(67, 71);
            this.BtUltimo.TabIndex = 6;
            this.BtUltimo.Text = "Ultimo";
            this.BtUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtUltimo.UseVisualStyleBackColor = true;
            this.BtUltimo.Click += new System.EventHandler(this.BtUltimo_Click);
            // 
            // BtAnterior
            // 
            this.BtAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtAnterior.Image")));
            this.BtAnterior.Location = new System.Drawing.Point(365, 2);
            this.BtAnterior.Name = "BtAnterior";
            this.BtAnterior.Size = new System.Drawing.Size(67, 71);
            this.BtAnterior.TabIndex = 5;
            this.BtAnterior.Text = "Anterior";
            this.BtAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtAnterior.UseVisualStyleBackColor = true;
            this.BtAnterior.Click += new System.EventHandler(this.BtAnterior_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtCancelar.Image")));
            this.BtCancelar.Location = new System.Drawing.Point(292, 2);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(67, 71);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtEliminar.Image")));
            this.BtEliminar.Location = new System.Drawing.Point(219, 2);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(67, 71);
            this.BtEliminar.TabIndex = 3;
            this.BtEliminar.Text = "Borrar";
            this.BtEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtEditar.Image")));
            this.BtEditar.Location = new System.Drawing.Point(146, 2);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(67, 71);
            this.BtEditar.TabIndex = 2;
            this.BtEditar.Text = "Editar";
            this.BtEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtGuardar.Image")));
            this.BtGuardar.Location = new System.Drawing.Point(73, 2);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(67, 71);
            this.BtGuardar.TabIndex = 1;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDep);
            this.groupBox2.Controls.Add(this.TbObs);
            this.groupBox2.Controls.Add(this.TbCar);
            this.groupBox2.Controls.Add(this.TbApe);
            this.groupBox2.Controls.Add(this.TbNbr);
            this.groupBox2.Controls.Add(this.TbDoc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbDep
            // 
            this.cbDep.DataSource = this.catbdependenciasBindingSource1;
            this.cbDep.DisplayMember = "DepNombre";
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(24, 183);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(161, 21);
            this.cbDep.TabIndex = 12;
            this.cbDep.ValueMember = "DepNombre";
            // 
            // catbdependenciasBindingSource1
            // 
            this.catbdependenciasBindingSource1.DataMember = "ca_tbdependencias";
            this.catbdependenciasBindingSource1.DataSource = this.controlAcceso1DataSet1;
            // 
            // controlAcceso1DataSet1
            // 
            this.controlAcceso1DataSet1.DataSetName = "ControlAcceso1DataSet1";
            this.controlAcceso1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbObs
            // 
            this.TbObs.Location = new System.Drawing.Point(24, 259);
            this.TbObs.Name = "TbObs";
            this.TbObs.Size = new System.Drawing.Size(346, 20);
            this.TbObs.TabIndex = 11;
            // 
            // TbCar
            // 
            this.TbCar.Location = new System.Drawing.Point(24, 221);
            this.TbCar.Name = "TbCar";
            this.TbCar.Size = new System.Drawing.Size(161, 20);
            this.TbCar.TabIndex = 10;
            // 
            // TbApe
            // 
            this.TbApe.Location = new System.Drawing.Point(24, 143);
            this.TbApe.Name = "TbApe";
            this.TbApe.Size = new System.Drawing.Size(161, 20);
            this.TbApe.TabIndex = 8;
            this.TbApe.TextChanged += new System.EventHandler(this.TbApe_TextChanged);
            // 
            // TbNbr
            // 
            this.TbNbr.Location = new System.Drawing.Point(24, 98);
            this.TbNbr.Name = "TbNbr";
            this.TbNbr.Size = new System.Drawing.Size(161, 20);
            this.TbNbr.TabIndex = 7;
            // 
            // TbDoc
            // 
            this.TbDoc.Location = new System.Drawing.Point(24, 57);
            this.TbDoc.Name = "TbDoc";
            this.TbDoc.Size = new System.Drawing.Size(161, 20);
            this.TbDoc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dependencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picCamera);
            this.groupBox3.Controls.Add(this.picImagen);
            this.groupBox3.Controls.Add(this.BtnFoto);
            this.groupBox3.Location = new System.Drawing.Point(377, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 315);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // picCamera
            // 
            this.picCamera.Location = new System.Drawing.Point(278, 42);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(133, 131);
            this.picCamera.TabIndex = 2;
            this.picCamera.TabStop = false;
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(24, 38);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(135, 135);
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            // 
            // BtnFoto
            // 
            this.BtnFoto.Image = ((System.Drawing.Image)(resources.GetObject("BtnFoto.Image")));
            this.BtnFoto.Location = new System.Drawing.Point(181, 98);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(75, 75);
            this.BtnFoto.TabIndex = 0;
            this.BtnFoto.Text = "Tomar Foto";
            this.BtnFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // controlAcceso1DataSet
            // 
            this.controlAcceso1DataSet.DataSetName = "ControlAcceso1DataSet";
            this.controlAcceso1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catbdependenciasBindingSource
            // 
            this.catbdependenciasBindingSource.DataMember = "ca_tbdependencias";
            this.catbdependenciasBindingSource.DataSource = this.controlAcceso1DataSet;
            this.catbdependenciasBindingSource.CurrentChanged += new System.EventHandler(this.catbdependenciasBindingSource_CurrentChanged);
            // 
            // ca_tbdependenciasTableAdapter
            // 
            this.ca_tbdependenciasTableAdapter.ClearBeforeFill = true;
            // 
            // ca_tbdependenciasTableAdapter1
            // 
            this.ca_tbdependenciasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 421);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEmpleados";
            this.Text = "frmRegistroEmpleados";
            this.Load += new System.EventHandler(this.frmRegistroEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtPrimero;
        private System.Windows.Forms.Button BtUltimo;
        private System.Windows.Forms.Button BtAnterior;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtSiguiente;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbObs;
        private System.Windows.Forms.TextBox TbCar;
        private System.Windows.Forms.TextBox TbApe;
        private System.Windows.Forms.TextBox TbNbr;
        private System.Windows.Forms.TextBox TbDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.BindingSource catbdependenciasBindingSource;
        private ControlAcceso1DataSetTableAdapters.ca_tbdependenciasTableAdapter ca_tbdependenciasTableAdapter;
        private ControlAcceso1DataSet controlAcceso1DataSet;
        private ControlAcceso1DataSet1 controlAcceso1DataSet1;
        private System.Windows.Forms.BindingSource catbdependenciasBindingSource1;
        private ControlAcceso1DataSet1TableAdapters.ca_tbdependenciasTableAdapter ca_tbdependenciasTableAdapter1;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.PictureBox picImagen;
    }
}
namespace ControlAcceso
{
    partial class frmIngresoVisitantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbApe = new System.Windows.Forms.TextBox();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btRegistroElementos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDependencia = new System.Windows.Forms.ComboBox();
            this.controlAcceso1DataSet2 = new ControlAcceso.ControlAcceso1DataSet2();
            this.catbdependenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ca_tbdependenciasTableAdapter = new ControlAcceso.ControlAcceso1DataSet2TableAdapters.ca_tbdependenciasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDependencia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Controls.Add(this.tbApe);
            this.groupBox1.Controls.Add(this.tbnom);
            this.groupBox1.Controls.Add(this.tbnum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(26, 200);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(133, 117);
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Foto";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(88, 127);
            this.tbTel.Name = "tbTel";
            this.tbTel.ReadOnly = true;
            this.tbTel.Size = new System.Drawing.Size(168, 20);
            this.tbTel.TabIndex = 7;
            // 
            // tbApe
            // 
            this.tbApe.Location = new System.Drawing.Point(88, 94);
            this.tbApe.Name = "tbApe";
            this.tbApe.ReadOnly = true;
            this.tbApe.Size = new System.Drawing.Size(168, 20);
            this.tbApe.TabIndex = 6;
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(88, 63);
            this.tbnom.Name = "tbnom";
            this.tbnom.ReadOnly = true;
            this.tbnom.Size = new System.Drawing.Size(168, 20);
            this.tbnom.TabIndex = 5;
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(146, 25);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(168, 20);
            this.tbnum.TabIndex = 4;
            this.tbnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Documento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Controls.Add(this.btRegistroElementos);
            this.groupBox2.Location = new System.Drawing.Point(541, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(69, 134);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(143, 56);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btRegistroElementos
            // 
            this.btRegistroElementos.Location = new System.Drawing.Point(69, 37);
            this.btRegistroElementos.Name = "btRegistroElementos";
            this.btRegistroElementos.Size = new System.Drawing.Size(143, 56);
            this.btRegistroElementos.TabIndex = 0;
            this.btRegistroElementos.Text = "Registrar Elementos";
            this.btRegistroElementos.UseVisualStyleBackColor = true;
            this.btRegistroElementos.Click += new System.EventHandler(this.btRegistroElementos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dependencia";
            // 
            // cmbDependencia
            // 
            this.cmbDependencia.DataSource = this.catbdependenciasBindingSource;
            this.cmbDependencia.DisplayMember = "DepNombre";
            this.cmbDependencia.FormattingEnabled = true;
            this.cmbDependencia.Location = new System.Drawing.Point(211, 200);
            this.cmbDependencia.Name = "cmbDependencia";
            this.cmbDependencia.Size = new System.Drawing.Size(179, 21);
            this.cmbDependencia.TabIndex = 12;
            this.cmbDependencia.ValueMember = "DepNombre";
            // 
            // controlAcceso1DataSet2
            // 
            this.controlAcceso1DataSet2.DataSetName = "ControlAcceso1DataSet2";
            this.controlAcceso1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catbdependenciasBindingSource
            // 
            this.catbdependenciasBindingSource.DataMember = "ca_tbdependencias";
            this.catbdependenciasBindingSource.DataSource = this.controlAcceso1DataSet2;
            // 
            // ca_tbdependenciasTableAdapter
            // 
            this.ca_tbdependenciasTableAdapter.ClearBeforeFill = true;
            // 
            // frmIngresoVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIngresoVisitantes";
            this.Text = "frmIngresoVisitantes";
            this.Load += new System.EventHandler(this.frmIngresoVisitantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlAcceso1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catbdependenciasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbApe;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btRegistroElementos;
        private System.Windows.Forms.ComboBox cmbDependencia;
        private System.Windows.Forms.Label label7;
        private ControlAcceso1DataSet2 controlAcceso1DataSet2;
        private System.Windows.Forms.BindingSource catbdependenciasBindingSource;
        private ControlAcceso1DataSet2TableAdapters.ca_tbdependenciasTableAdapter ca_tbdependenciasTableAdapter;
    }
}
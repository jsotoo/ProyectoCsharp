namespace ControlAcceso
{
    partial class frmRestaurarBD
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
            this.btRespaldo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRespaldo
            // 
            this.btRespaldo.Location = new System.Drawing.Point(42, 53);
            this.btRespaldo.Name = "btRespaldo";
            this.btRespaldo.Size = new System.Drawing.Size(379, 83);
            this.btRespaldo.TabIndex = 2;
            this.btRespaldo.Text = "Restaurar Base de datos";
            this.btRespaldo.UseVisualStyleBackColor = true;
            this.btRespaldo.Click += new System.EventHandler(this.btRespaldo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRespaldo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restauración de la base de datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmRestaurarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRestaurarBD";
            this.Text = "frmRestaurarBD";
            this.Load += new System.EventHandler(this.frmRestaurarBD_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRespaldo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
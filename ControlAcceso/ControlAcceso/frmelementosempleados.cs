using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAcceso
{
    public partial class frmelementosempleados : Form
    {
        private int documento;
        Funciones f = new Funciones();
        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        public frmelementosempleados()
        {
            InitializeComponent();
        }

        private void frmelementosempleados_Load(object sender, EventArgs e)
        {
            txtDocumento.Text = this.Documento.ToString();
            txtSerial.Focus();
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtElemento.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtElemento.Text != String.Empty)
            {
                try
                {
                    if(f.ingresarElementos(Convert.ToInt32(txtDocumento.Text),txtSerial.Text,txtElemento.Text))
                    {
                        MessageBox.Show("Elemento Ingresado correctamente", "Control de acceso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSerial.Text = String.Empty;
                        txtElemento.Text = String.Empty;
                        txtSerial.Focus();
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Contro de acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Faltan Datos", "Contro de acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

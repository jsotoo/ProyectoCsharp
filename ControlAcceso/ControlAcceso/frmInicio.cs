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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = progressBar1.Value;
            if (progressBar1.Value < 100)
            {
                
                load.Text = x.ToString();
                progressBar1.Value += 2;
            }
                
            else
            {
                
                load.Text = x.ToString();
                timer1.Enabled = false;
                frmLogin nuevo = new frmLogin();
                nuevo.Show();
                this.Hide();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}

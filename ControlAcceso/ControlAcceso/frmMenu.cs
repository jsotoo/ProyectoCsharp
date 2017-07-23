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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleados nuevo = new frmRegistroEmpleados();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void registrosVisitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVisitantes nuevo = new frmRegistroVisitantes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void ingresoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmIngresoEmpleado nuevo = new frmIngresoEmpleado();
            //nuevo.MdiParent = this;
            //nuevo.Show();
            frmIngresoEmpleaos nuevo = new frmIngresoEmpleaos();
            nuevo.MdiParent = this;
            nuevo.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ingresoVisitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoVisitantes nuevo = new frmIngresoVisitantes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios nuevo = new frmUsuarios();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void dependenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDependencias nuevo = new frmDependencias();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void copiaDeBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackUp nuevo = new frmBackUp();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void restaurarCopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestaurarBD nuevo = new frmRestaurarBD();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}

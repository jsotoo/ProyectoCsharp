using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlAcceso
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        Funciones f = new Funciones();
        sesion s = new sesion();

        public String nomUsu;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                f.Consulta = "Select * from ca_tbusuarios where usulogin='" + txtlogin.Text + "' and  usupassword ='" + txtpassword.Text + "' and Usuestado='Activo'";

                f.OperarRegistro(f.Consulta);
                if (f.DT.Rows.Count > 0)
                {
                    MessageBox.Show("Usuario validado correctamente");
                    frmMenu nuevo = new frmMenu();
                    frmIngresoEmpleaos usuario = new frmIngresoEmpleaos();
                    usuario.setUserlog(txtlogin.Text);
                    frmIngresoVisitantes vis = new frmIngresoVisitantes();
                    vis.setUserlog(txtlogin.Text);
                    nuevo.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Usuario no esta registrado");
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void txtlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(null, null);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUsuarios nuevo = new frmUsuarios();
            nuevo.Show();
        }
    }
}

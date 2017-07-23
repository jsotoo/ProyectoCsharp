using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ControlAcceso
{
    public partial class frmRestaurarBD : Form
    {
        Comandos cmd = new Comandos();
        String fecha = DateTime.Now.ToString("yyyy-MM-dd");
        String CadenaConexion = "Data Source = USUARIO\\SQLEXPRESS; Initial Catalog = ControlAcceso1;Integrated Security=yes;";
        public frmRestaurarBD()
        {
            InitializeComponent();
        }

        private void frmRestaurarBD_Load(object sender, EventArgs e)
        {

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btRespaldo_Click(object sender, EventArgs e)
        {
            //poner cursor de relojito
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"c:\Bakcup\ControlAcceso1.bak"))
                {
                    if (MessageBox.Show("¿Está seguro de restaurar?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //esto puede ser un método aparte de conexion a la base de datos-----------
                        SqlConnection connect;
                        string con = "Data Source = USUARIO\\SQLEXPRESS; Initial Catalog=master ;Integrated Security = True;";
                        connect = new SqlConnection(con);
                        connect.Open();
                        //--------------------------------------------------------------------------

                        //esto puede ser un método aparte para ejecutar comandos SQL----------------
                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"restore database ControlAcceso1 from disk = 'c:\Bakcup\ControlAcceso1.bak'", connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Se ha restaurado la base de datos", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"No haz hecho ningun respaldo anteriormente (o no está en la ruta correcta)", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
    }


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
    public partial class frmBackUp : Form
    {
        String CadenaConexion = "Data Source = USUARIO\\SQLEXPRESS; Initial Catalog = ControlAcceso1;Integrated Security=yes;";
        SqlConnection con = new SqlConnection(ControlAcceso.Properties.Settings.Default.ControlAcceso1ConnectionString);
        public frmBackUp()
        {
            InitializeComponent();
        }

        

        private void btnbackup_Click(object sender, EventArgs e)
        {

            bool desea_respaldar = true;
            Cursor.Current = Cursors.WaitCursor;
            if (Directory.Exists(@"c:\Bakcup"))
            {
                if (File.Exists(@"c:\Bakcup\ControlAcceso1.bak"))
                {
                    if (MessageBox.Show(@"Ya existe un backup con ese nombre, \n Desea reemplazarla?", "Control De Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\Bakcup\ControlAcceso1.bak");
                    }
                    else
                        desea_respaldar = false;
                }
            }
            else
                Directory.CreateDirectory(@"c:\Bakcup");

            if (desea_respaldar)
            {
                SqlConnection connect;

                

                connect = new SqlConnection(CadenaConexion);
                connect.Open();

                SqlCommand command;
                command = new SqlCommand(@"backup database ControlAcceso1 to disk ='c:\Bakcup\ControlAcceso1.bak' with init,stats=10", connect);
                command.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Copia de la base de datos exitosa", "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
    }


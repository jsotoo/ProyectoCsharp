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
    public partial class frmIngresoEmpleaos : Form
    {
        Funciones f = new Funciones();

        static String userlog;  
        public void setUserlog(String usr)
        {
            userlog = usr;
        }

        public frmIngresoEmpleaos()
        {
            InitializeComponent();
        }

        private void tbDocunmento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean enc = false;
           
           

            if (e.KeyChar == 13)
            {
                enc = f.existenciaEmpleado(tbDocumento.Text);
                if (enc)
                {
                    tbNombres.Text = f.DR.ItemArray[1].ToString();
                    tbApellidos.Text = f.DR.ItemArray[2].ToString();
                    pbxFoto.ImageLocation = Application.StartupPath + "\\Fotos\\" + f.DR.ItemArray[6].ToString();
                }
                else
                {
                    if (MessageBox.Show("Empleado no encontrado \nDesea agregarlo",
                            "Control de Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        f.fb = true;
                        frmRegistroEmpleados otro = new frmRegistroEmpleados();
                        otro.MdiParent = this.MdiParent;
                        otro.Show();
                        otro.BtNuevo_Click(null, null);
                    }


                }
            }
        }

        private void frmIngresoEmpleaos_Load(object sender, EventArgs e)
        {

        }

        private void tbDocumento_MouseClick(object sender, MouseEventArgs e)
        {
            tbDocumento.SelectionStart = 0;
            tbDocumento.SelectionLength = tbDocumento.Text.Length;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                String observa = "";
                Boolean enc = false;
                String fa = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String fecactual = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String horingreso = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                
                if (tbDocumento.Text != String.Empty)
                {
                    enc = f.existenciaEmpleado(tbDocumento.Text);
                    if (enc)
                    {
                        f.Consulta = "Select * from ca_tbingresosempleados Where empdocumento=" + tbDocumento.Text + "AND empfecha='" + fa + "'";
                        f.OperarRegistro(f.Consulta);
                        if (f.DT.Rows.Count > 0)
                        {
                            String horactual = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                            f.DR = f.DT.Rows[0];
                            observa = f.DR.ItemArray[6].ToString() + " " + tbObservaciones.Text;
                            if (f.DR.ItemArray[3].ToString() == "00:00:00")
                            {

                                f.Consulta = "Update ca_tbingresosempleados Set Emphorasalida1='" + horactual + "', empobservaciones ='" + observa + "' Where Empdocumento=" + tbDocumento.Text;
                                mensaje = "Salida Hecha";
                            }
                            else if (f.DR.ItemArray[4].ToString() == "00:00:00")
                            {
                                f.Consulta = "Update ca_tbingresosempleados Set Emphoraentrada2='" + horactual + "', empobservaciones ='" + observa + "' Where Empdocumento=" + tbDocumento.Text;
                                mensaje = "Ingreso Hecho";
                            }
                            else if (f.DR.ItemArray[5].ToString() == "00:00:00")
                            {
                                f.Consulta = "Update ca_tbingresosempleados Set Emphorasalida2='" + horactual + "', empobservaciones ='" + observa + "' Where Empdocumento=" + tbDocumento.Text;
                                mensaje = "Salida Hecha";
                            }
                            else
                            {
                                f.Consulta = "Insert into ca_tbingresosempleados values ('" + tbDocumento.Text + "','" + fecactual + "','" + horingreso + "','00:00:00','00:00:00','00:00:00','" + tbObservaciones.Text + "','" + userlog + "');";

                            }
                            f.OperarRegistro(f.Consulta);
                            MessageBox.Show(mensaje, "Control Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            f.Consulta = "Insert into ca_tbingresosempleados values ('" + tbDocumento.Text + "','" + fecactual + "','" + horingreso + "','00:00:00','00:00:00','00:00:00','" + tbObservaciones.Text + "','" + userlog + "');";
                            f.OperarRegistro(f.Consulta);
                            MessageBox.Show("Ingreso hecho", "Control Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                        MessageBox.Show("No existe el documento", "control acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                    MessageBox.Show("El campo documento esta vacio!", "control acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }

        }
        private void btnRegistrarElementos_Click(object sender, EventArgs e)
        {
            if (tbDocumento.Text != String.Empty)
            {
                frmelementosempleados nuevo = new frmelementosempleados();
                nuevo.Documento = Convert.ToInt32(tbDocumento.Text);
                nuevo.Show();   
            }
            else
            {
                MessageBox.Show("No ha ingresado un documento", "Control de acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}


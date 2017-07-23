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
    public partial class frmIngresoVisitantes : Form
    {
        Funciones f = new Funciones();
        static String userlog;
        public void setUserlog(String usr)
        {
            userlog = usr;
        }




        public frmIngresoVisitantes()
        {
            InitializeComponent();
        }





        private void frmIngresoVisitantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet2.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            this.ca_tbdependenciasTableAdapter.Fill(this.controlAcceso1DataSet2.ca_tbdependencias);

        }

        private void tbnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean enc = false;
            if (e.KeyChar == 13)
            {
                enc = f.existenciaVisitante(tbnum.Text);
                if (enc)
                {
                   tbnom.Text = f.DR.ItemArray[1].ToString();
                   tbApe.Text = f.DR.ItemArray[2].ToString();
                   tbTel.Text = f.DR.ItemArray[4].ToString();
                    pbFoto.ImageLocation = Application.StartupPath + "\\FotosVisitantes\\" + f.DR.ItemArray[5].ToString();
                }
                else
                {
                    if (MessageBox.Show("Visitante no encontrado \nDesea agregarlo",
                            "Control de Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        f.fb = true;
                        frmRegistroVisitantes otro = new frmRegistroVisitantes();
                        otro.MdiParent = this.MdiParent;
                        otro.Show();
                        otro.BtNuevo_Click_1(null, null);
                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                Boolean enc = false;
                String fa = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String fecactual = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String horingreso = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;

                if (tbnum.Text != String.Empty)
                {
                    enc = f.existenciaVisitante(tbnum.Text);
                    if (enc)
                    {
                        f.Consulta = "Select * from ca_tbvisitantesingresos Where VisDocumento=" + tbnum.Text + "AND VisFechaIngreso='" + fa + "'";
                        f.OperarRegistro(f.Consulta);
                        if (f.DT.Rows.Count > 0)
                        {
                            String horactual = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                            f.DR = f.DT.Rows[0];
                            if (f.DR.ItemArray[5].ToString() == "00:00:00")
                            {

                                f.Consulta = "Update ca_tbvisitantesingresos Set Vishorasalida='" + horactual + "', VisDependencia ='" + cmbDependencia.Text + "' Where VisDocumento=" + tbnum.Text;
                                mensaje = "Salida Hecha";
                            }
                            else if (f.DR.ItemArray[3].ToString() == "00:00:00")
                            {
                                f.Consulta = "Update ca_tbvisitantesingresos Set Vishoraingreso='" + horactual + "', VisDependencia ='" + cmbDependencia.Text + "' Where VisDocumento=" + tbnum.Text;
                                mensaje = "Ingreso Hecho";
                            }
                           
                            else
                            {
                              f.Consulta = "Insert into ca_tbvisitantesingresos values ('" + tbnum.Text + "','" + cmbDependencia.Text+ "','"+ fecactual +"','"+ "00:00:00"+"','" + fecactual+ "','"+ "00:00:00"+   "','" + userlog + "');";

                            }
                            f.OperarRegistro(f.Consulta);
                            MessageBox.Show(mensaje, "Control Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            f.Consulta = "Insert into ca_tbvisitantesingresos values ('" + tbnum.Text + "','" + cmbDependencia.Text + "','" + fecactual +"','"+"00:00:00" +"','"+ fecactual + "','"+ "00:00:00" + "','" + userlog + "');";
                            f.OperarRegistro(f.Consulta);
                            MessageBox.Show("Ingreso hecho", "Control Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                        MessageBox.Show("No existe el documento", "control acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El campo documento esta vacio!", "control acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }

        }

        private void btRegistroElementos_Click(object sender, EventArgs e)
        {
            if (tbnum.Text != String.Empty)
            {
                frmElementosVisitantes nuevo = new frmElementosVisitantes();
                nuevo.Documento = Convert.ToInt32(tbnum.Text);
                nuevo.Show();
            }
            else
            {
                MessageBox.Show("No ha ingresado un documento", "Control de acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace ControlAcceso
{
    public partial class frmRegistroEmpleados : Form
    {

        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        Funciones f = new Funciones();
        int fila = 0;
        int Mfila = 0;
        Boolean nueReg = false;
        Boolean bq= false;
        Boolean editReg = false;
        public frmRegistroEmpleados()
        {
            InitializeComponent();
            BuscarDispositivos();
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
            bloquearCampos();
            Conectar();
            Mfila = f.DT.Rows.Count - 1;
        }
        private void Conectar()
        {
            f.Consulta = "Select * from ca_tbempleados";
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.OperarRegistro(f.Consulta);
            
            if (f.DT.Rows.Count > 0)
            {
                BtPrimero_Click(null, null);
            }
        }
        private void Comprobar(String var)
        {
            f.Consulta = "Select * from ca_tbempleados where EmpDocumento="+var;
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.DT = new DataTable();
            f.DA.Fill(f.DT);
            if (f.DT.Rows.Count > 0)
            {
                BtPrimero_Click(null, null);
                bloquearControles(false, false, true, true, true, true, false, false, false, false);
            }
            else {
                MessageBox.Show("El empleado no existe");
                limpiarCampos();
                bloquearControles(false, false, false, true, false, true, false, false, false, false);
            }
        }

        private void BtPrimero_Click(object sender, EventArgs e)
        {
            fila = 0;
            mostrarDatos(fila);
            Mfila = f.DT.Rows.Count - 1;
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }
        private void mostrarDatos(int fil)
        {
            f.DR = f.DT.Rows[fil];
            TbDoc.Text = f.DR.ItemArray[0].ToString();
            TbNbr.Text = f.DR.ItemArray[1].ToString();
            TbApe.Text = f.DR.ItemArray[2].ToString();
            cbDep.Text = f.DR.ItemArray[3].ToString();
            TbCar.Text = f.DR.ItemArray[4].ToString();
            TbObs.Text = f.DR.ItemArray[5].ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegistroEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet1.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            this.ca_tbdependenciasTableAdapter1.Fill(this.controlAcceso1DataSet1.ca_tbdependencias);
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            //this.ca_tbdependenciasTableAdapter.Fill(this.controlAcceso1DataSet.ca_tbdependencias);
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet1.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            Conectar();
            if(f.fb==true)
            {
                BtNuevo_Click(null, null);
                f.fb = false;
            }
            if(existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra nngun dispostivo de video en el sistma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CerrarFormulario();

            }


        }

        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;
        }

        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            picImagen.Image = imagen;
        }

        private void CerrarFormulario()
        {
            if( fuenteDeVideo != null)
            {
                if(fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Capturar();
            fotografiaHecha = true;
        }

        private void Capturar()
        {
            if ( fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    picCamera.Image = picImagen.Image;
                }
            }
        }

        public void BtNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            desbloquearCampos();
            bloquearControles(true, true, false, false, false, true, true, true, true, true);
            TbDoc.Focus();
            nueReg = true;
        }
        private void bloquearControles(Boolean a, Boolean b, Boolean c, Boolean d, Boolean e, Boolean f, Boolean g, Boolean h, Boolean i, Boolean j)
        {

            
            BtNuevo.Enabled = a;
            BtGuardar.Enabled = b;
            BtEditar.Enabled = c;
            BtBuscar.Enabled = d;
            BtCancelar.Enabled = f;
            BtEliminar.Enabled = e;
            BtPrimero.Enabled = g;
            BtAnterior.Enabled = h;
            BtSiguiente.Enabled = i;
            BtUltimo.Enabled = j;
        }
        private void limpiarCampos()
        {
            TbDoc.Text = "";
            TbNbr.Text = "";
            TbApe.Text = "";
            cbDep.Text = "";
            TbCar.Text = "";
            TbObs.Text = "";
        }
        private void desbloquearCampos()
        {
            TbDoc.ReadOnly = false;
            TbNbr.ReadOnly = false;
            TbApe.ReadOnly = false;
            TbCar.ReadOnly = false;
            TbObs.ReadOnly = false;
        }
        private void bloquearCampos()
        {
            TbDoc.ReadOnly = true;
            TbNbr.ReadOnly = true;
            TbApe.ReadOnly = true;
            TbCar.ReadOnly = true;
            TbObs.ReadOnly = true;
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            String VDoc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Numero de documento del Empleado");
            Comprobar(VDoc);
            bq = true;
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fotografiaHecha)
                {
                    if (TbDoc.Text != String.Empty
                        && TbNbr.Text != String.Empty
                        && TbApe.Text != String.Empty
                        && TbCar.Text != String.Empty
                        )
                    {

                        if (validarCampos() == false)
                {
                    if (nueReg == true)
                    {
                                Rectangle formaRecorte = new Rectangle(0, 0, 200, 200);
                                Bitmap imagenOrigen = (Bitmap)picCamera.Image;
                                Bitmap imagen = imagenOrigen.Clone(formaRecorte, imagenOrigen.PixelFormat);
                                String ruta = Application.StartupPath + "\\Fotos\\"  + TbDoc.Text + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".png";
                                String archivo = TbDoc.Text + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".png";
                                imagen.Save(ruta);
                                ruta = ruta.Replace(@"\", @"\\");
                                f.CadIns = "execute InsertarEmpleados '" + TbDoc.Text + "','" + TbNbr.Text + "','" + TbApe.Text + "','" + cbDep.Text + "','" + TbCar.Text + "','" + TbObs.Text + "', '" +archivo + "'";
                                f.OperarRegistro(f.CadIns);
                                nueReg = false;
                                MessageBox.Show("Ingreso Correcto");
                                Conectar();
                                BtUltimo_Click(null, null);
                                bloquearControles(true, false, true, true, false, false, true, true, true, true);
                                bloquearCampos();
                                Mfila = f.DT.Rows.Count - 1;
                            }
                            if (editReg == true)
                            {
                                f.CadIns = "UPDATE ca_tbempleados SET EmpDocumento=" + TbDoc.Text + ",EmpNombres='" + TbNbr.Text + "',EmpApellidos='" + TbApe.Text +"',EmpDependencia ='" + cbDep.Text + "', EmpCargo='" + TbCar.Text + "', EmpObservaciones='" + TbObs.Text + "' where EmpDocumento='" + TbDoc.Text + "'";
                                f.OperarRegistro(f.CadIns);
                                nueReg = false;
                                MessageBox.Show("Actualizacion Exitosa");
                                Conectar();
                                BtUltimo_Click(null, null);
                                bloquearControles(true, false, true, true, false, false, true, true, true, true);
                                bloquearCampos();
                                Mfila = f.DT.Rows.Count - 1;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato Invalido o Faltan datos");
                    }
                }
                else
                {
                    MessageBox.Show("No ha capturado la fotografía del empleado","Control de Acceso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool validarCampos()
        {
            bool error = false;
            if (TbDoc.Text == "" || TbNbr.Text == "" || TbApe.Text == "" || cbDep.Text == "" || TbCar.Text == "" || TbObs.Text == "")
            {

                error = true;
            }
            return error;
        }

        private void BtUltimo_Click(object sender, EventArgs e)
        {
            fila = f.DT.Rows.Count - 1;
            mostrarDatos(fila);
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            bloquearControles(false, true, false, true, false, true, false, false, false, false);
            editReg = true;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (bq == true || nueReg == true || editReg == true)
            {
                if (MessageBox.Show("Actualmente esta modificando o Adicionando un registro " + "desea realmente cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    bloquearControles(true, false, true, true, false, false, true, true, true, true);
                    bloquearCampos();
                    Conectar();
                    nueReg = false;
                    editReg = false;
                }
            }
        }

        private void BtSiguiente_Click(object sender, EventArgs e)
        {
            if (Mfila <= fila)
            {
                fila = 0;
                mostrarDatos(fila);
            }
            else {
                fila = fila + 1;
                mostrarDatos(fila);
            }
    }

        private void BtAnterior_Click(object sender, EventArgs e)
        {
            if (fila <= 0)
            {
                fila = f.DT.Rows.Count - 1;
                mostrarDatos(fila);
            }
            else{
                fila = fila - 1;
                mostrarDatos(fila);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (nueReg == false || editReg == false)
            {
                if (TbDoc.Text != "")
                {
                    f.CadIns = "DELETE FROM ca_tbempleados WHERE EmpDocumento=" + TbDoc.Text + ";";
                    f.OperarRegistro(f.CadIns);
                    nueReg = false;
                    MessageBox.Show("Registro eliminado de forma Exitosa");
                    Conectar();
                    BtUltimo_Click(null, null);
                    bloquearControles(true, false, true, true, false, false, true, true, true, true);
                    bloquearCampos();
                    Mfila = f.DT.Rows.Count - 1;
                }
                else
                {

                }
            }
            else {
                MessageBox.Show("Esta Haciendo una operacion de edicion o creacion, debe cancelar toda operacion para poder eliminar un registro");
            }
        }

        private void catbdependenciasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TbApe_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

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
    public partial class frmUsuarios : Form
    {


        Funciones f = new Funciones();
        int fila = 0;
        int Mfila = 0;
        Boolean nueReg = false;
        Boolean bq = false;
        Boolean editReg = false;
        public frmUsuarios()
        {
            InitializeComponent();
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
            bloquearCampos();
            Conectar();
            Mfila = f.DT.Rows.Count - 1;
        }
        private void Conectar()
        {
            f.Consulta = "Select * from ca_tbusuarios";
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.OperarRegistro(f.Consulta);

            if (f.DT.Rows.Count > 0)
            {
                BtnPrimero_Click(null, null);
            }
        }
        private void Comprobar(String var)
        {
            f.Consulta = "Select * from ca_tbusuarios where UsuDocumento=" + var;
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.DT = new DataTable();
            f.DA.Fill(f.DT);
            if (f.DT.Rows.Count > 0)
            {
                BtnPrimero_Click(null, null);
                bloquearControles(false, false, true, true, true, true, false, false, false, false);
            }
            else {
                MessageBox.Show("El usuario no existe");
                limpiarCampos();
                bloquearControles(false, false, false, true, false, true, false, false, false, false);
            }
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            fila = 0;
            mostrarDatos(fila);
            Mfila = f.DT.Rows.Count - 1;
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }
        private void mostrarDatos(int fil)
        {
            f.DR = f.DT.Rows[fil];
            txtDocumento.Text = f.DR.ItemArray[0].ToString();
            txtnombres.Text = f.DR.ItemArray[1].ToString();
            txtapellidos.Text = f.DR.ItemArray[2].ToString();
            txtcorreo.Text = f.DR.ItemArray[3].ToString();
            txtlogin.Text = f.DR.ItemArray[4].ToString();
            txtpassword.Text = f.DR.ItemArray[5].ToString();
            txtPerfil.Text = f.DR.ItemArray[6].ToString();
            txtEstado.Text = f.DR.ItemArray[7].ToString();
        }
      
       
        

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet1.ca_tbdependencias' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            //this.ca_tbdependenciasTableAdapter.Fill(this.controlAcceso1DataSet.ca_tbdependencias);
            // TODO: esta línea de código carga datos en la tabla 'controlAcceso1DataSet1.ca_tbdependencias' Puede moverla o quitarla según sea necesario.
            Conectar();
            if (f.fb == true)
            {
                BtnNuevo_Click(null, null);
                f.fb = false;
            }



        }



        public void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            desbloquearCampos();
            bloquearControles(true, true, false, false, false, true, true, true, true, true);
            txtDocumento.Focus();
            nueReg = true;
        }
        private void bloquearControles(Boolean a, Boolean b, Boolean c, Boolean d, Boolean e, Boolean f, Boolean g, Boolean h, Boolean i, Boolean j)
        {


            BtnNuevo.Enabled = a;
            BtnGuardar.Enabled = b;
            BtnEditar.Enabled = c;
            BtnBuscar.Enabled = d;
            BtnCancelar.Enabled = f;
            BtnEliminar.Enabled = e;
            BtnPrimero.Enabled = g;
            BtnAnterior.Enabled = h;
            BtnSiguiente.Enabled = i;
            BtnUltimo.Enabled = j;
        }
        private void limpiarCampos()
        {
            txtDocumento.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtcorreo.Text = "";
            txtlogin.Text = "";
            txtpassword.Text = "";
            txtPerfil.Text = "";
            txtEstado.Text = "";
        }
        private void desbloquearCampos()
        {
            txtDocumento.ReadOnly = false;
            txtnombres.ReadOnly = false;
            txtapellidos.ReadOnly = false;
            txtcorreo.ReadOnly = false;
            txtlogin.ReadOnly = false;
            txtpassword.ReadOnly = false;

        }
        private void bloquearCampos()
        {
            txtDocumento.ReadOnly = true;
            txtnombres.ReadOnly = true;
            txtapellidos.ReadOnly = true;
            txtcorreo.ReadOnly = true;
            txtlogin.ReadOnly = true;
            txtpassword.ReadOnly = true;

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            String VDoc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Numero de documento del usuario");
            Comprobar(VDoc);
            bq = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (validarCampos() == false)
                {
                    if (nueReg == true)
                    {

                        f.CadIns = "execute InsertarUsuarios '" + txtDocumento.Text + "','" + txtnombres.Text + "','" + txtapellidos.Text + "','" + txtcorreo.Text + "','" + txtlogin.Text + "','" + txtpassword.Text + "', '" + txtPerfil.Text + "','" + txtEstado.Text + "'";
                        f.OperarRegistro(f.CadIns);
                        nueReg = false;
                        MessageBox.Show("Ingreso Correcto");
                        Conectar();
                        BtnUltimo_Click(null, null);
                        bloquearControles(true, false, true, true, false, false, true, true, true, true);
                        bloquearCampos();
                        Mfila = f.DT.Rows.Count - 1;
                    }
                    if (editReg == true)
                    {
                        f.CadIns = "UPDATE ca_tbusuarios SET UsuDocumento=" + txtDocumento.Text + ",UsuNombres='" + txtnombres.Text + "',UsuApellidos='" + txtapellidos.Text + "',UsuCorreo ='" + txtcorreo.Text + "', UsuLogin='" + txtlogin.Text + "', UsuPassword='" + txtpassword.Text + "',UsuPerfil='" + txtPerfil.Text + "',UsuEstado='" + txtEstado.Text + "' where UsuDocumento='" + txtDocumento.Text + "'";
                        f.OperarRegistro(f.CadIns);
                        nueReg = false;
                        MessageBox.Show("Actualizacion Exitosa");
                        Conectar();
                        BtnUltimo_Click(null, null);
                        bloquearControles(true, false, true, true, false, false, true, true, true, true);
                        bloquearCampos();
                        Mfila = f.DT.Rows.Count - 1;
                    }

                }

                else
                {
                    MessageBox.Show("Formato Invalido o Faltan datos");
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
            if (txtDocumento.Text == "" || txtnombres.Text == "" || txtapellidos.Text == "" || txtcorreo.Text == "" || txtlogin.Text == "" || txtpassword.Text == "" || txtPerfil.Text == "" || txtEstado.Text == "")
            {

                error = true;
            }
            return error;
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            fila = f.DT.Rows.Count - 1;
            mostrarDatos(fila);
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            desbloquearCampos();
            bloquearControles(false, true, false, true, false, true, false, false, false, false);
            editReg = true;
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
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

        private void BtnSiguiente_Click_1(object sender, EventArgs e)
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

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (fila <= 0)
            {
                fila = f.DT.Rows.Count - 1;
                mostrarDatos(fila);
            }
            else {
                fila = fila - 1;
                mostrarDatos(fila);
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (nueReg == false || editReg == false)
            {
                if (txtDocumento.Text != "")
                {
                    f.CadIns = "DELETE FROM ca_tbusuarios WHERE UsuDocumento=" + txtDocumento.Text + ";";
                    f.OperarRegistro(f.CadIns);
                    nueReg = false;
                    MessageBox.Show("Registro eliminado de forma Exitosa");
                    Conectar();
                    BtnUltimo_Click(null, null);
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

        
    }
}

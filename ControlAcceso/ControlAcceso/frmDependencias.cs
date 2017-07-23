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
    public partial class frmDependencias : Form
    {
        Funciones f = new Funciones();
        int fila = 0;
        int Mfila = 0;
        Boolean nueReg = false;
        Boolean bq = false;
        Boolean editReg = false;
        public frmDependencias()
        {
            InitializeComponent();
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
            bloquearCampos();
            Conectar();
            Mfila = f.DT.Rows.Count - 1;
        }
        private void Conectar()
        {
            f.Consulta = "Select * from ca_tbdependencias";
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.OperarRegistro(f.Consulta);

            if (f.DT.Rows.Count > 0)
            {
                BtnPrimero_Click(null, null);
            }
        }

        private void Comprobar(String var)
        {
            f.Consulta = "Select * from ca_tbdependencias where DepNombre=" + var;
            f.DA = new SqlDataAdapter(f.Consulta, f.CadenaConexion);
            f.DT = new DataTable();
            f.DA.Fill(f.DT);
            if (f.DT.Rows.Count > 0)
            {
                BtnPrimero_Click(null, null);
                bloquearControles(false, false, true, true, true, true, false, false, false, false);
            }
            else {
                MessageBox.Show("la dependencia no existe");
                limpiarCampos();
                bloquearControles(false, false, false, true, false, true, false, false, false, false);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            desbloquearCampos();
            bloquearControles(true, true, false, false, false, true, true, true, true, true);
            txtDependencia.Focus();
            nueReg = true;

        }
        private void mostrarDatos(int fil)
        {
            f.DR = f.DT.Rows[fil];
            txtDependencia.Text = f.DR.ItemArray[0].ToString();
            
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
            txtDependencia.Text = "";
          
        }
        private void desbloquearCampos()
        {
            txtDependencia.ReadOnly = false;
           

        }
        private void bloquearCampos()
        {
            txtDependencia.ReadOnly = true;

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (validarCampos() == false)
                {
                    if (nueReg == true)
                    {

                        f.CadIns = "execute InsertarDependencias '"  + txtDependencia.Text + "'";
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
                        f.CadIns = "UPDATE ca_tbdependencias SET DepNombre="  + txtDependencia.Text + "' where DepNombre='" + txtDependencia.Text + "'";
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
            if (txtDependencia.Text == "")
            {

                error = true;
            }
            return error;
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            bloquearControles(false, true, false, true, false, true, false, false, false, false);
            editReg = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (nueReg == false || editReg == false)
            {
                if (txtDependencia.Text != "")
                {
                    f.CadIns = "DELETE FROM ca_tbdependencias WHERE DepNombre=" + txtDependencia.Text + ";";
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
    

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            fila = f.DT.Rows.Count - 1;
            mostrarDatos(fila);
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            fila = 0;
            mostrarDatos(fila);
            Mfila = f.DT.Rows.Count - 1;
            bloquearControles(true, false, true, true, true, false, true, true, true, true);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String VDoc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la dependencia");
            Comprobar(VDoc);
            bq = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {

        }

        private void frmDependencias_Load(object sender, EventArgs e)
        {
            Conectar();
            if (f.fb == true)
            {
                BtnNuevo_Click(null, null);
                f.fb = false;
            }

        }
    }
}

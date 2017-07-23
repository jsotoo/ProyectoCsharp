using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ControlAcceso
{
    class Funciones
    {
        public String CadenaConexion = "Data Source = USUARIO\\SQLEXPRESS; Initial Catalog = ControlAcceso1;Integrated Security=yes;";
        public SqlDataAdapter DA;
        public DataTable DT;
        public DataTable DT1;
        public DataRow DR;
        public String Consulta;
        public String CadIns;
        public Boolean fb = false;

        public void OperarRegistro(String cad)
        {
            DA = new SqlDataAdapter(cad, CadenaConexion);
            DT = new DataTable();
            DA.Fill(DT);
        }


        public Boolean existenciaEmpleado( string Documento)
        {
            Boolean est;
            String cad = "SELECT * FROM ca_tbempleados WHERE EmpDocumento=" + Documento;
            DA = new SqlDataAdapter(cad, CadenaConexion);
            DT = new DataTable();
            DA.Fill(DT);

            if(DT.Rows.Count > 0)
            {
                est = true;
                DR = DT.Rows[0];
            }
            else
            {
                est = false;
            }


            return est;
        }


        public Boolean existenciaVisitante(string Documento)
        {
            Boolean est;
            String cad = "SELECT * FROM ca_tbvisitantes WHERE VisDocumento=" + Documento;
            DA = new SqlDataAdapter(cad, CadenaConexion);
            DT = new DataTable();
            DA.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                est = true;
                DR = DT.Rows[0];
            }
            else
            {
                est = false;
            }


            return est;
        }
        public Boolean ingresarElementos(int documento,String Serial,String elementos)
        {
            try
            {
                String fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String ConSQL = "INSERT INTO ca_tbempleadoselementos VALUES ('"
                + documento + "','" + Serial + "','" + elementos + "','" + fecha + "')";
                DA = new SqlDataAdapter(ConSQL, CadenaConexion);
                DT1 = new DataTable();
                DA.Fill(DT1);
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean ingresarElementosVisitantes(int documento, String Serial, String elementos)
        {
            try
            {
                String fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                String ConSQL = "INSERT INTO ca_tbvisitanteselementos VALUES ('"
                + documento + "','" + Serial + "','" + elementos + "','" + fecha + "')";
                DA = new SqlDataAdapter(ConSQL, CadenaConexion);
                DT1 = new DataTable();
                DA.Fill(DT1);
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean existenciaUsuario(string logueado)
        {
            Boolean est;
            String cad = "SELECT * FROM ca_tbusuarios WHERE UsuLogin=" + logueado;
            DA = new SqlDataAdapter(cad, CadenaConexion);
            DT = new DataTable();
            DA.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                est = true;
                DR = DT.Rows[0];
            }
            else
            {
                est = false;
            }


            return est;
        }


    }




}

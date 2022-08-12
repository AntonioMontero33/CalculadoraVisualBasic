using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//Namespace acceso a SQL Server
using System.Data.SqlClient; //Sql Server
using System.Data; // Datos generales
using System.Configuration; //Archivos de config

namespace AccesoADatos
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar una escuela")]
        public DataSet Listar(){
            string consulta = "exec spListarEscuela";
            //Entorno desconectado para acceder a la Escuela 
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Listar una escuela")]
        public bool AgregarEscuela(string CodEscuela, string Nombre, string Departamento)
        {
            string consulta = "exec spAgregarEscuela @CodEscuela =' "+ CodEscuela+" ', @Escuela = '"+Nombre+"', @Facultad = '"+Departamento+"'";
            //Entorno desconectado para acceder a la Escuela 
            SqlCommand command = new SqlCommand(consulta, conexion);
            conexion.Open();
            byte i = Convert.ToByte(command.ExecuteNonQuery());
            conexion.Close();
            if (i == 1) return true;
            else return false;
        }


        [WebMethod(Description = "Suma de Doubles")]
        public double SumaOperaciones(double nro1, double nro2)
        {
            double resultado;
            resultado = nro1 + nro2;
            return resultado;

        }

        [WebMethod(Description = "Potencia de Doubles")]
        public double PotenciaOperaciones(double base1, double exp)
        {
            double resultado;
            resultado = Math.Pow(base1, exp);
            return resultado;

        }

    }
}

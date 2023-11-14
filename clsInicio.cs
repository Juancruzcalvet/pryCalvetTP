using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryTPCalvet
{
    internal class clsInicio
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDS = new DataSet();
        string RutaConexionBase;
        String EstadoDeConexion="";
        public clsInicio()
        {

            try
            {
                RutaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = C:\\Users\\Juan\\Desktop\\pryCalvetTP\\DB\\EMPLEADO.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = RutaConexionBase;
                conexionBD.Open();

                objDS = new DataSet();

                EstadoDeConexion = "Conectado";
            }
            catch (Exception error)
            {
                EstadoDeConexion = error.Message;
            }


            //Construimos para tener la conexión y comandos
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }
    }

}

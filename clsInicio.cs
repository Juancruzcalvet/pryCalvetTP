using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

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
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source =C:\\Users\\Juan\\Desktop\\pryCalvetTP\\DB\\EMPLEADO.accdb");
                conexionBD.Open();
   


                EstadoDeConexion = "Conectado";
            }
            catch (Exception ex)
            {
                EstadoDeConexion = "Error" + ex.Message;
            }

        }
        public void CrearUsuario(string Nombre, string Apellido, string Direccion, string Ciudad, string Telefono, DateTime Nacimiento)
        {
            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter adaptador;
            DataSet objds = new DataSet(); 

            try
            {
                //Conectamos la tabla
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                //Traemos tabla 
                comandoBD.CommandText = "DATOS PERSONALES";

                //Abrir la tabla y mostrar por renglón
                lectorBD = comandoBD.ExecuteReader();

                // Verificar si tiene algo
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read()) //Leemos
                    {
                        if (lectorBD[2].ToString() == Nombre & lectorBD[3].ToString() == Apellido)
                        {
                            MessageBox.Show("Ya está registrad@.");
                            return; //Salimos del método si ya existe esa persona.
                        }
                    }
                }

                // Cerrar el DataReader después de usarlo para evitar conflictos
                lectorBD.Close();

                // Crear el objeto DataAdapter pasando como parámetro el objeto comando que queremos vincular
                adaptador = new OleDbDataAdapter(comandoBD);

                // Ejecutar la lectura de la tabla y almacenar su contenido en el dataAdapter
                adaptador.Fill(objds, "DATOS PERSONALES");

                // Obtener una referencia a la tabla de Usuarios
                DataTable tabla = objds.Tables["DATOS PERSONALES"];

                // Crear el nuevo DataRow con la estructura de campos de la tabla Usuarios
                DataRow nuevoRegistro = tabla.NewRow();

                // Asignar los valores a todos los campos del DataRow
                nuevoRegistro["NOMBRE"] = Nombre;
                nuevoRegistro["APELLIDO"] = Apellido;
                nuevoRegistro["DIRECCIÒN"] = Direccion;
                nuevoRegistro["CIUDAD"] = Ciudad;
                nuevoRegistro["TELEFONO"] = Telefono;
                nuevoRegistro["FECHA_NACIMIENTO"] = Nacimiento;

                // Agregar el DataRow a la tabla Usuarios
                tabla.Rows.Add(nuevoRegistro);

                // Crear el objeto OleDbCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);

                // Actualizar la base con los cambios realizados
                adaptador.Update(objds, "NOMBRE");

                MessageBox.Show("Usuario creado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar el DataReader en el bloque finally
                if (lectorBD != null && !lectorBD.IsClosed)
                {
                    lectorBD.Close();
                }
            }
        }
    }

}

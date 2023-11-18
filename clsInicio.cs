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
        
        DataSet objDS = new DataSet();
        
        String EstadoDeConexion="";
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\DB\\EMPLEADO.accdb");
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
        //Contiene int i para poder cambiar el indice de la columna buscada. 
        //String busca es donde se inserta la búsqueda (x nombre,apellido,etc)
        public void Buscar(string Busca, DataGridView Grilla, int i)
        {
            
            try
            {
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "DATOS PERSONALES";
                lectorBD = comandoBD.ExecuteReader();
                //Booleano para saber si se encuentra el valor deseado o no.
                bool seEncuentra = false;
                Grilla.Columns.Add("CODIGO", "CODIGO");
                Grilla.Columns.Add("NOMBRE", "NOMBRE");
                Grilla.Columns.Add("APELLIDO", "APELLIDO");
                Grilla.Columns.Add("DIRECCIÒN", "DIRECCIÒN");
                Grilla.Columns.Add("CIUDAD", "CIUDAD");
                Grilla.Columns.Add("TELEFONO", "TELEFONO");
                Grilla.Columns.Add("FECHA_NACIMIENTO", "FECHA_NACIMIENTO");
                //mientras haya filas
                if (lectorBD.HasRows)
                {
                    //leemos registro por registro
                    while (lectorBD.Read())
                    {
                        //si valor = a lo ingresado por txt
                        if ((lectorBD[i].ToString()) == Busca)
                        {
                            Grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6]);
                            seEncuentra = true;
                        }
                    }

                    if (seEncuentra == false)
                    {
                        MessageBox.Show("Empleado no existe", "Consulta");
                    }
                }
            }
            catch (Exception error)
            {
                EstadoDeConexion = "Error:" + error.Message;
            }
        }
        public void CargarGrilla(DataGridView Grilla)
        {

            try
            {
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "DATOS PERSONALES";
                lectorBD = comandoBD.ExecuteReader();
                Grilla.Columns.Add("CODIGO", "CODIGO");
                Grilla.Columns.Add("NOMBRE", "NOMBRE");
                Grilla.Columns.Add("APELLIDO", "APELLIDO");
                Grilla.Columns.Add("DIRECCIÒN", "DIRECCIÒN");
                Grilla.Columns.Add("CIUDAD", "CIUDAD");
                Grilla.Columns.Add("TELEFONO", "TELEFONO");
                Grilla.Columns.Add("FECHA_NACIMIENTO", "FECHA_NACIMIENTO");
                //mientras haya filas
                if (lectorBD.HasRows)
                {
                    //leemos registro por registro
                    while (lectorBD.Read())
                    {
                        Grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6]);
                    }

                }
            }
            catch (Exception error)
            {
                EstadoDeConexion = "Error:" + error.Message;
            }
        }
    }
}

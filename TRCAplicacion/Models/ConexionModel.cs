using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Controllers.Login;

namespace TRCAplicacion.Models
{
    internal class ConexionModel
    {
        private static NpgsqlConnection conexion = null;
        private static NpgsqlCommand comando = null;
        private static NpgsqlDataAdapter da = null;
        private static System.Data.DataTable dt = null;
        private static string cadenaConexion = String.Empty;

        // Varialbles privadas para la cadena de conexion
        private static string servidor = "tienda-cris.postgres.database.azure.com";
        private string bd = "Tienda_Cris";
        //private static string usuario = "BellorinAxel";
        //private static string contrasena = "Axel070801";
        private static string usuario = LoginC.Usuario;
        private static string contrasena = LoginC.Contrasena;
        private string puerto = "5432";

        public static string Servidor { get => servidor; set => servidor = value; }
        public string Bd { get => bd; set => bd = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Contrasena { get => contrasena; set => contrasena = value; }
        public string Puerto { get => puerto; set => puerto = value; }

        public ConexionModel()
        {
            cadenaConexion =
            "server = " + Servidor +
            "; port = " + Puerto +
            "; user id = " + Usuario +
            "; password = " + Contrasena +
            "; database = " + Bd +
            "; SSLMode = Prefer";
        }

        public bool accesoCorrecto(string usuario, string contrasena)
        {
            try
            {
                //Usuario = usuario;
                //Contrasena = contrasena;

                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion

                comando.Connection = conexion;

                // Se abre la conexion
                conexion.Open();
                return true;
            }

            catch
            {
                return false;
            }

            finally
            {
                conexion.Dispose();
                //comando.Dispose();
            }
        }

        // Insertar, Actualzar, Eliminar
        public void ejecutarFuncion(NpgsqlParameter[] parametros, string nombreFuncion)
        {
            try
            {
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se agregan los aprametros
                comando.Parameters.AddRange(parametros);
                // Se ejecuta el comando
                comando.ExecuteNonQuery();

                //System.Windows.Forms.MessageBox.Show("Operacion exitosa", "Informacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido realizar la opereacion\n" + excepcion.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
        }

        public System.Data.DataTable ratornarTabla(string nombreFuncion)
        {
            dt = null;

            try
            {
                dt = new System.Data.DataTable();
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se instancia el adaptador con el comando
                da = new NpgsqlDataAdapter(comando);
                // Se llena el dataset con el adaprtador de datos
                da.Fill(dt);

                //System.Windows.Forms.MessageBox.Show("Operacion exitosa", "Informacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido realizar la opereacion\n" + excepcion.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
                da.Dispose();
            }

            return dt;
        }

        public System.Data.DataTable ratornarTabla(NpgsqlParameter[] parametros, string nombreFuncion)
        {
            dt = null;

            try
            {
                dt = new System.Data.DataTable();
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se agregan los parametros
                comando.Parameters.AddRange(parametros);
                // Se instancia el adaptador con el comando
                da = new NpgsqlDataAdapter(comando);
                // Se llena el dataset con el adaprtador de datos
                da.Fill(dt);

                //System.Windows.Forms.MessageBox.Show("Operacion exitosa", "Informacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido realizar la opereacion\n" + excepcion.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); System.Windows.Forms.MessageBox.Show(excepcion.Message);
                //throw new Exception(excepcion.Message);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
                da.Dispose();
            }

            return dt;
        }


        public System.Data.DataTable ratornarDatosReportes(string consulta)
        {
            dt = null;

            try
            {
                dt = new System.Data.DataTable();
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.Text;
                // Se indica el nombre de la funcion
                comando.CommandText = consulta;
                // Se instancia el adaptador con el comando
                da = new NpgsqlDataAdapter(comando);
                // Se llena el dataset con el adaprtador de datos
                da.Fill(dt);

                //System.Windows.Forms.MessageBox.Show("Operacion exitosa", "Informacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show("No se ha podido realizar la opereacion\n" + excepcion.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
                da.Dispose();
            }

            return dt;
        }
    }
}

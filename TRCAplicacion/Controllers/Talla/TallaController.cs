using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Talla
{
    internal class TallaController
    {
        ConexionModel conex = null;
        TallaC objTalla = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de TallaControlador
        public TallaController(TallaC parObjTalla)
        {
            objTalla = parObjTalla;
        }

        // Retornar tabla con las Tallas
        public System.Data.DataTable mostrarTallas()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_talla");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarTalla()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@talla";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objTalla.Nombre;

            conex.ejecutarFuncion(parametros, "venta.insertar_talla");
        }

        public void actualizarTalla(string talla_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@talla_vieja";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[0].NpgsqlValue = talla_vieja;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@talla_nueva";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[1].NpgsqlValue = objTalla.Nombre;

            conex.ejecutarFuncion(parametros, "venta.actualizar_talla");
        }

        public void eliminarTalla(string talla)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@talla";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = talla;

            conex.ejecutarFuncion(parametros, "venta.eliminar_talla");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.EstadoEncargo
{
    internal class EstadoEncargoController
    {
        ConexionModel conex = null;
        EstadoEncargoC objEstadoEncargo = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de CargoControlador
        public EstadoEncargoController(EstadoEncargoC parObjEstadoEncargo)
        {
            objEstadoEncargo = parObjEstadoEncargo;
        }

        public System.Data.DataTable mostrarEstadoEncargo()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_estado_encargo");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarEstadoEncargo()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@estado_encargo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objEstadoEncargo.Nombre;

            conex.ejecutarFuncion(parametros, "venta.insertar_estado_encargo");
        }

        public void actualizarEstadoEncargo(string estado_encargo_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@estado_encargo_vieja";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[0].NpgsqlValue = estado_encargo_vieja;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@estado_encargo_nueva";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[1].NpgsqlValue = objEstadoEncargo.Nombre;

            conex.ejecutarFuncion(parametros, "venta.actualizar_estado_encargo");
        }

        public void eliminarEstadoEncargo(string estado_encargo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@estado_encargo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = estado_encargo;

            conex.ejecutarFuncion(parametros, "venta.eliminar_estado_encargo");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class PuntoReunionController
    {
        ConexionModel conex = null;
        PuntoReunionC objPuntoReunion = null;
        System.Data.DataTable dt = null;

        public PuntoReunionController(PuntoReunionC parObjPuntoReunion)
        {
            objPuntoReunion = parObjPuntoReunion;
        }


        // Retornar tabla con los puntos de reunion
        public System.Data.DataTable mostrarPuntosReunion(string municipio, string departamento, string pais)
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                NpgsqlParameter[] parametros = new NpgsqlParameter[3];

                parametros[0] = new NpgsqlParameter();
                parametros[0].ParameterName = "@municipio";
                parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[0].NpgsqlValue = municipio;

                parametros[1] = new NpgsqlParameter();
                parametros[1].ParameterName = "@departamento";
                parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[1].NpgsqlValue = departamento;

                parametros[2] = new NpgsqlParameter();
                parametros[2].ParameterName = "@pais";
                parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[2].NpgsqlValue = pais;

                dt = conex.ratornarTabla(parametros, "venta.mostrar_punto_reunion_parametro");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }



        public void insertarPuntoReunion()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@punto_reunion";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objPuntoReunion.PuntoReunion;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@municipio";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objPuntoReunion.Municipio;

            conex.ejecutarFuncion(parametros, "venta.insertar_punto_reunion");
        }



        public void actualizarPuntoReunion(string puntoReunionviejo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@punto_reunion_viejo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = puntoReunionviejo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@punto_reunion_nuevo";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objPuntoReunion.PuntoReunion;

            conex.ejecutarFuncion(parametros, "venta.actualizar_punto_reunion");
        }

        public void eliminarPuntoReunion(string puntoReunion)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@punto_reunion";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = puntoReunion;

            conex.ejecutarFuncion(parametros, "venta.eliminar_punto_reunion");
        }




    }
}

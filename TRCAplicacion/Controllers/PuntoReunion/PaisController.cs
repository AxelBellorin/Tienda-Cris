using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class PaisController
    {
        ConexionModel conex = null;
        PaisC objPais = null;
        System.Data.DataTable dt = null;

        public PaisController(PaisC parObjPais)
        {
            objPais = parObjPais;
        }

        // Retornar tabla con los paises
        public System.Data.DataTable mostrarPaises()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_pais");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarPais()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@pais";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objPais.Pais;

            conex.ejecutarFuncion(parametros, "venta.insertar_pais");
        }



        public void actualizarPais(string paisViejo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@pais_viejo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = paisViejo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@pais_nuevo";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objPais.Pais;

            conex.ejecutarFuncion(parametros, "venta.actualizar_pais");
        }

        public void eliminarPais(string pais)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@pais";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = pais;

            conex.ejecutarFuncion(parametros, "venta.eliminar_pais");
        }


    }
}

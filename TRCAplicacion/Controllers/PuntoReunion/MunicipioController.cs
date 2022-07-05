using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class MunicipioController
    {
        ConexionModel conex = null;
        MunicipioC objMunicipio = null;
        System.Data.DataTable dt = null;

        public MunicipioController(MunicipioC parObjMunicipio)
        {
            objMunicipio = parObjMunicipio;
        }

        // Retornar tabla con los paises
        public System.Data.DataTable mostrarMunicipios(string departamento, string pais)
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                NpgsqlParameter[] parametros = new NpgsqlParameter[2];

                parametros[0] = new NpgsqlParameter();
                parametros[0].ParameterName = "@departamento";
                parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[0].NpgsqlValue = departamento;

                parametros[1] = new NpgsqlParameter();
                parametros[1].ParameterName = "@pais";
                parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[1].NpgsqlValue = pais;

                dt = conex.ratornarTabla(parametros, "venta.mostrar_municipio_parametros");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }



        public void insertarMunicipio()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@municipio";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objMunicipio.Municipio;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@departamento";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objMunicipio.Departamento;

            conex.ejecutarFuncion(parametros, "venta.insertar_municipio");
        }



        public void actualizarMunicipio(string municipioViejo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@municipio_viejo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = municipioViejo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@municipio_nuevo";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objMunicipio.Municipio;

            conex.ejecutarFuncion(parametros, "venta.actualizar_municipio");
        }

        public void eliminarMunicipio(string municipio)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@municipio";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = municipio;

            conex.ejecutarFuncion(parametros, "venta.eliminar_municipio");
        }




    }
}

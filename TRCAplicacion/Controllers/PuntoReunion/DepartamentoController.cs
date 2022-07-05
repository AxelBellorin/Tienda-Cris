using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class DepartamentoController
    {
        ConexionModel conex = null;
        DepartamentoC objDepartamento = null;
        System.Data.DataTable dt = null;

        public DepartamentoController(DepartamentoC parObjDepartamento)
        {
            objDepartamento = parObjDepartamento;
        }


        // Retornar tabla con los paises
        public System.Data.DataTable mostrarDepartamentos(string pais)
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].ParameterName = "@pais";
                parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                parametros[0].NpgsqlValue = pais;

                dt = conex.ratornarTabla(parametros, "venta.mostrar_departamento_parametros");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }


        public void insertarDepartamento()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@departamento";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objDepartamento.Departamento;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@pais";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objDepartamento.Pais;

            conex.ejecutarFuncion(parametros, "venta.insertar_departamento");
        }



        public void actualizarDepartamento(string departamentoViejo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@departamento_viejo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = departamentoViejo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@departamento_nuevo";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objDepartamento.Departamento;

            conex.ejecutarFuncion(parametros, "venta.actualizar_departamento");
        }

        public void eliminarDepartamento(string departamento)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@departamento";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = departamento;

            conex.ejecutarFuncion(parametros, "venta.eliminar_departamento");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Marca
{
    internal class MarcaController
    {
        ConexionModel conex = null;
        MarcaC objMarca = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de ClienteControlador
        public MarcaController(MarcaC parObjMarca)
        {
            objMarca = parObjMarca;
        }

        // Retornar tabla con las Categorias
        public System.Data.DataTable mostrarMarcas()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_marca");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarMarca()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objMarca.Nombre;

            conex.ejecutarFuncion(parametros, "venta.insertar_marca");
        }


        public void actualizarMarca (string marca_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@marca_vieja";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[0].NpgsqlValue = marca_vieja;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@marca_nueva";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[1].NpgsqlValue = objMarca.Nombre;

            conex.ejecutarFuncion(parametros, "venta.actualizar_marca");
        }

        public void eliminarMarca(string marca)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@marca";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = marca;

            conex.ejecutarFuncion(parametros, "venta.eliminar_marca");
        }
    }
}

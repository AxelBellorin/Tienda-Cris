using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Categoria
{
    internal class CategoriaController
    {
        ConexionModel conex = null;
        CategoriaC objCategoria = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de ClienteControlador
        public CategoriaController(CategoriaC parObjCategoria)
        {
            objCategoria = parObjCategoria;
        }

        // Retornar tabla con las Categorias
        public System.Data.DataTable mostrarCategorias()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_categoria");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarCategoria()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@categoria";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objCategoria.Nombre;

            conex.ejecutarFuncion(parametros, "venta.insertar_categoria");
        }


        public void actualizarCategoria(string categoria_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@categoria_vieja";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[0].NpgsqlValue = categoria_vieja;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@categoria_nueva";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[1].NpgsqlValue = objCategoria.Nombre;

            conex.ejecutarFuncion(parametros, "venta.actualizar_categoria");
        }

        public void eliminarCategoria(string categoria)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@categoria";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = categoria;

            conex.ejecutarFuncion(parametros, "venta.eliminar_categoria");
        }
    }
}

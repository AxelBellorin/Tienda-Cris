using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Producto
{
    internal class ProductoController
    {
        ConexionModel conex = null;
        ProductoC objProducto = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de ProductoControlador
        public ProductoController(ProductoC parObjProducto)
        {
            objProducto = parObjProducto;
        }

        // Retornar tabla con los Productos
        public System.Data.DataTable mostrarProductos()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_productos");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarProducto()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[5];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@codigo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objProducto.CodProducto;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@descripcion";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objProducto.Descripcion;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@categoria";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[2].NpgsqlValue = objProducto.Categoria;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@marca";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[3].NpgsqlValue = objProducto.Marca;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@talla";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[4].Size = 20;
            parametros[4].NpgsqlValue = objProducto.Talla;

            conex.ejecutarFuncion(parametros, "venta.insertar_producto");
        }
    }
}

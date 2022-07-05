using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.CompraProveedor
{
    internal class CompraProveedorController
    {
        ConexionModel conex = null;
        CompraProveedorC objCompraProveedor = null;
        System.Data.DataTable dt = null;

        public CompraProveedorController(CompraProveedorC parObjCompraProveedor)
        {
            objCompraProveedor = parObjCompraProveedor;
        }

        public void insertarCompraProveedor()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[6];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@codigo_factura";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[0].NpgsqlValue = objCompraProveedor.CodCompra;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@nombre_compania";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[1].NpgsqlValue = objCompraProveedor.NombreCompania;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@codigo_producto";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[2].NpgsqlValue = objCompraProveedor.CodProducto;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@cantidad_producto";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            parametros[3].NpgsqlValue = objCompraProveedor.Cantidad;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@precio_compra";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Double;
            parametros[4].NpgsqlValue = objCompraProveedor.Precio;

            parametros[5] = new NpgsqlParameter();
            parametros[5].ParameterName = "@band";
            parametros[5].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Boolean;
            parametros[5].NpgsqlValue = objCompraProveedor.Band;

            conex.ejecutarFuncion(parametros, "venta.proceso_compra");
        }
    }
}

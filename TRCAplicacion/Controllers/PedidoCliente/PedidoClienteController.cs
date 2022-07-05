using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.PedidoCliente
{
    internal class PedidoClienteController
    {
        ConexionModel conex = null;
        PedidoClienteC objPedidoCliente = null;
        System.Data.DataTable dt = null;

        public PedidoClienteController(PedidoClienteC parObjPedidoCliente)
        {
            objPedidoCliente = parObjPedidoCliente;
        }

        public void insertarPedidoCliente()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[8];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@codigo_pedido";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objPedidoCliente.CodigoPedido;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@fecha_entrega";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Date;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objPedidoCliente.FechaEntrega;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@cedula_cliente";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[2].NpgsqlValue = objPedidoCliente.Cedula;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@punto_reunion";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[3].NpgsqlValue = objPedidoCliente.PuntoReunion;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@tipo_pago";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[4].NpgsqlValue = objPedidoCliente.TipoPago;

            parametros[5] = new NpgsqlParameter();
            parametros[5].ParameterName = "@codigo_producto";
            parametros[5].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[5].NpgsqlValue = objPedidoCliente.CodigoProducto;

            parametros[6] = new NpgsqlParameter();
            parametros[6].ParameterName = "@cantidad_producto";
            parametros[6].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            // parametros[6].Size = 20;
            parametros[6].NpgsqlValue = objPedidoCliente.CantidadProducto;

            parametros[7] = new NpgsqlParameter();
            parametros[7].ParameterName = "@band";
            parametros[7].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Boolean;
            // parametros[7].Size = 20;
            parametros[7].NpgsqlValue = objPedidoCliente.Band;

            conex.ejecutarFuncion(parametros, "venta.proceso_pedido");
        }
    }
}

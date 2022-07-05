using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.EncargoCliente
{
    internal class EncargoClienteController
    {
        ConexionModel conex = null;
        EncargoClienteC objEncargoCliente = null;
        System.Data.DataTable dt = null;

        public EncargoClienteController(EncargoClienteC parObjEncargoCliente)
        {
            objEncargoCliente = parObjEncargoCliente;
        }

        public void insertarEncargoCliente()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[7];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@codigo_encargo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objEncargoCliente.CodigoEncargo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@cedula_cliente";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objEncargoCliente.CedulaCliente;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@estado_encargo";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[2].NpgsqlValue = objEncargoCliente.EstadoEncargo;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@tipo_pago";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[3].NpgsqlValue = objEncargoCliente.TipoPago;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@codigo_producto";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[4].NpgsqlValue = objEncargoCliente.CodigoProducto;

            parametros[5] = new NpgsqlParameter();
            parametros[5].ParameterName = "@cantidad_producto";
            parametros[5].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            // parametros[3].Size = 20;
            parametros[5].NpgsqlValue = objEncargoCliente.CantidadProducto;

            parametros[6] = new NpgsqlParameter();
            parametros[6].ParameterName = "@band";
            parametros[6].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Boolean;
            // parametros[3].Size = 20;
            parametros[6].NpgsqlValue = objEncargoCliente.Band;

            conex.ejecutarFuncion(parametros, "venta.proceso_encargo");
        }
    }
}

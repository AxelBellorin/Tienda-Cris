using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.TipoPago
{
    internal class TipoPagoController
    {
        ConexionModel conex = null;
        TipoPagoC objTipoPago = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de TipoPagoC
        public TipoPagoController(TipoPagoC parObjTipoPago)
        {
            objTipoPago = parObjTipoPago;
        }

        // Retornar tabla con las Tallas
        public System.Data.DataTable mostrarTipoPago()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_tipo_pago");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarTipoPago()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@tipo_pago";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objTipoPago.Nombre;

            conex.ejecutarFuncion(parametros, "venta.insertar_tipo_pago");
        }

        public void actualizarTipoPago(string tipo_pago_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@tipo_pago_vieja";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[0].NpgsqlValue = tipo_pago_vieja;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@tipo_pago_nueva";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[1].NpgsqlValue = objTipoPago.Nombre;

            conex.ejecutarFuncion(parametros, "venta.actualizar_tipo_pago");
        }

        public void eliminarTipoPago(string tipo_pago)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@tipo_pago";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = tipo_pago;

            conex.ejecutarFuncion(parametros, "venta.eliminar_tipo_pago");
        }
    }
}
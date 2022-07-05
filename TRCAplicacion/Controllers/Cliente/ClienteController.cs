using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Cliente
{
    internal class ClienteController
    {
        ConexionModel conex = null;
        ClienteC objCliente = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de ClienteControlador
        public ClienteController(ClienteC parObjCliente)
        {
            objCliente = parObjCliente;
        }

        // Retornar tabla con los clientes
        public System.Data.DataTable mostrarClientes()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_cliente");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarCliente()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[4];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objCliente.Nombres;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@apellido";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objCliente.Apellidos;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@cedula";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[2].NpgsqlValue = objCliente.Cedula;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@telefono";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[3].NpgsqlValue = objCliente.Telefono;

            conex.ejecutarFuncion(parametros, "venta.insertar_cliente");
        }

        public void actualizarCliente(string cedula_vieja)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[5];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objCliente.Nombres;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@apellido";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objCliente.Apellidos;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@telefono";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[2].NpgsqlValue = objCliente.Telefono;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@cedula_vieja";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[3].NpgsqlValue = cedula_vieja;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@cedula_nueva";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[4].NpgsqlValue = objCliente.Cedula;

            conex.ejecutarFuncion(parametros, "venta.actualizar_cliente");
        }

        public void eliminarCliente(string cedula)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@cedula";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = cedula;

            conex.ejecutarFuncion(parametros, "venta.eliminar_cliente");
        }
    }
}

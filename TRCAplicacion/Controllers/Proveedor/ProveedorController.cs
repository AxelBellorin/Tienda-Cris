using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Proveedor
{
    internal class ProveedorController
    {
        ConexionModel conex = null;
        ProveedorC objProveedor = null;
        System.Data.DataTable dt = null;


        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de ProveedorControlador
        public ProveedorController(ProveedorC parObjProveedor)
        {
            objProveedor = parObjProveedor;
        }

        // Retornar tabla con los Proveedores
        public System.Data.DataTable mostrarProveedor()
        {
            dt = new System.Data.DataTable();

            try
            {
                conex = new ConexionModel();

                dt = conex.ratornarTabla("venta.mostrar_proveedor");
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            return dt;
        }

        public void insertarProveedor()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[4];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre_compania";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = objProveedor.Nombre;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@telefono";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objProveedor.Telefono;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@direccion";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[2].NpgsqlValue = objProveedor.Direccion;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@ruc";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[3].NpgsqlValue = objProveedor.Ruc;

            conex.ejecutarFuncion(parametros, "venta.insertar_proveedor");
        }

        public void actualizarProveedor(string nombre_compañia_viejo)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[5];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre_compañia_viejo";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = nombre_compañia_viejo;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@nombre_compañia_nuevo";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[1].Size = 20;
            parametros[1].NpgsqlValue = objProveedor.Nombre;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@telefono";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[3].Size = 20;
            parametros[2].NpgsqlValue = objProveedor.Telefono;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@direccion";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[2].Size = 20;
            parametros[3].NpgsqlValue = objProveedor.Direccion;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@ruc";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[4].Size = 20;
            parametros[4].NpgsqlValue = objProveedor.Ruc;

            conex.ejecutarFuncion(parametros, "venta.actualizar_proveedor");
        }

        public void eliminarProveedor(string nombre_compañia)
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[1];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre_compañia";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            // parametros[0].Size = 20;
            parametros[0].NpgsqlValue = nombre_compañia;

            conex.ejecutarFuncion(parametros, "venta.eliminar_proveedor");
        }
    }
}

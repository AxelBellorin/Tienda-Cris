using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Trabajador
{
    internal class TrabajadorController
    {
        ConexionModel conex = null;
        TrabajadorC objTrabajador = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        // recibe como parametro un objeto de TipoPagoC
        public TrabajadorController(TrabajadorC parObjTrabajador)
        {
            objTrabajador = parObjTrabajador;
        }

        public void insertarTrabajador()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[8];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@nombre";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[0].NpgsqlValue = objTrabajador.Nombres;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@apellido";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[1].NpgsqlValue = objTrabajador.Apellidos;

            parametros[2] = new NpgsqlParameter();
            parametros[2].ParameterName = "@cedula";
            parametros[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[2].NpgsqlValue = objTrabajador.Cedula;

            parametros[3] = new NpgsqlParameter();
            parametros[3].ParameterName = "@telefono";
            parametros[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[3].NpgsqlValue = objTrabajador.Telefono;

            parametros[4] = new NpgsqlParameter();
            parametros[4].ParameterName = "@direccion";
            parametros[4].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[4].NpgsqlValue = objTrabajador.Direccion;

            parametros[5] = new NpgsqlParameter();
            parametros[5].ParameterName = "@cargo";
            parametros[5].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[5].NpgsqlValue = objTrabajador.Cargo;

            parametros[6] = new NpgsqlParameter();
            parametros[6].ParameterName = "@users";
            parametros[6].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[6].NpgsqlValue = objTrabajador.Usuario;

            parametros[7] = new NpgsqlParameter();
            parametros[7].ParameterName = "@passwords";
            parametros[7].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[7].NpgsqlValue = objTrabajador.Contrasena;

            conex.ejecutarFuncion(parametros, "venta.insertar_trabajador");
        }
    }
}

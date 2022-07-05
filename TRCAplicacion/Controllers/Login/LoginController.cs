using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.Login
{
    internal class LoginController
    {
        ConexionModel conex = null;
        LoginC objLogin = null;
        System.Data.DataTable dt = null;

        // Constructor de la clase sobrecargado,
        public LoginController(LoginC parObjLogin)
        {
            objLogin = parObjLogin;
        }

        public bool verificarAcceso()
        {
            conex = new ConexionModel();

            NpgsqlParameter[] parametros = new NpgsqlParameter[2];

            parametros[0] = new NpgsqlParameter();
            parametros[0].ParameterName = "@User";
            parametros[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[0].NpgsqlValue = LoginC.Usuario;

            parametros[1] = new NpgsqlParameter();
            parametros[1].ParameterName = "@Contraseña";
            parametros[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parametros[1].NpgsqlValue = LoginC.Contrasena;

            return conex.accesoCorrecto(parametros[0].NpgsqlValue.ToString(), parametros[1].NpgsqlValue.ToString());
        }
    }
}

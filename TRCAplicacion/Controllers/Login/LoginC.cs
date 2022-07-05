using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.Login
{
    internal class LoginC
    {
        private static string usuario;
        private static string contrasena;

        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Contrasena { get => contrasena; set => contrasena = value; }
    }
}

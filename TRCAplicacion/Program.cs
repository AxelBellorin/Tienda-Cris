using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TRCAplicacion.GUI;

namespace TRCAplicacion
{
    public static class Conexion2
    {
        private static string usuario = "";
        private static string contrasena = "";

        public static string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDITienda());
        }
    }
}

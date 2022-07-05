using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.Productos
{
    internal static class ProductosC
    {
        private static string codProducto;
        private static int stockProducto;

        public static string CodProducto { get => codProducto; set => codProducto = value; }
        public static int StockProducto { get => stockProducto; set => stockProducto = value; }
    }
}

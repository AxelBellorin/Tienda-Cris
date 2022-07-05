using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.CompraProveedor
{
    internal class CompraProveedorC
    {
        private string codCompra;
        private string nombreCompania;
        private string codProducto;
        private int cantidad;
        private double precio;
        private bool band;

        public string CodCompra { get => codCompra; set => codCompra = value; }
        public string NombreCompania { get => nombreCompania; set => nombreCompania = value; }
        public string CodProducto { get => codProducto; set => codProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Band { get => band; set => band = value; }
    }
}

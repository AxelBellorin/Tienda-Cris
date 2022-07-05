using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.Proveedor
{
    internal class ProveedorC
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private string ruc;

        private string busqueda;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Busqueda { get => busqueda; set => busqueda = value; }
    }
}

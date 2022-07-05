using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.Cliente
{
    internal class ClienteC
    {
        // Propiedades de la Clase
        private string nombres;
        private string apellidos;
        private string cedula;
        private string telefono;

        private string busqueda;

        // Encapsulamiento de campos a traves de los metodos Set y Get
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Busqueda { get => busqueda; set => busqueda = value; }
    }
}

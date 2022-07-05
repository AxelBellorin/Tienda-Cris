using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.EncargoCliente
{
    internal class EncargoClienteC
    {
        private string codigoEncargo;
        private string cedulaCliente;
        private string estadoEncargo;
        private string tipoPago;
        private string codigoProducto;
        private int cantidadProducto;
        private bool band;

        public string CodigoEncargo { get => codigoEncargo; set => codigoEncargo = value; }
        public string CedulaCliente { get => cedulaCliente; set => cedulaCliente = value; }
        public string EstadoEncargo { get => estadoEncargo; set => estadoEncargo = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public bool Band { get => band; set => band = value; }
    }
}

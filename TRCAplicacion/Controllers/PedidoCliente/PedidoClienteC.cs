using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.PedidoCliente
{
    internal class PedidoClienteC
    {
        private string codigoPedido;
        private DateTime fechaEntrega;
        private string cedula;
        private string puntoReunion;
        private string tipoPago;
        private string codigoProducto;
        private int cantidadProducto;
        private bool band;

        public string CodigoPedido { get => codigoPedido; set => codigoPedido = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string PuntoReunion { get => puntoReunion; set => puntoReunion = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public bool Band { get => band; set => band = value; }
    }
}

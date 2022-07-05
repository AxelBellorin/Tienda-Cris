using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.Producto
{
    internal class ProductoC
    {
        private string codProducto;
        private string categoria;
        private string descripcion;
        //private int stock;
        //private float precio;
        private string talla;
        private string marca;

        private string busqueda;

        public string CodProducto { get => codProducto; set => codProducto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Busqueda { get => busqueda; set => busqueda = value; }
    }
}

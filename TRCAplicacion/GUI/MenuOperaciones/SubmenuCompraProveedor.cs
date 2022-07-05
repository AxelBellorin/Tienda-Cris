using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using TRCAplicacion.Controllers.CompraProveedor;

using TRCAplicacion.Controllers.Productos;
using TRCAplicacion.GUI.MenuOperaciones.Otros;

namespace TRCAplicacion.GUI.MenuOperaciones
{
    public partial class SubmenuCompraProveedor : Form
    {
        CompraProveedorC objCompraProveedorC = null;
        CompraProveedorController objCompraProveedorController = null;
        DataTable dt = null;

        private struct producto
        {
            public string codigoProducto;
            public int cantidadProducto;
        }

        private List<producto> listaProducto = new List<producto>();

        public SubmenuCompraProveedor()
        {
            InitializeComponent();
        }

        private void SubmenuCompraProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarProductoLista_Click(object sender, EventArgs e)
        {
            if (txtCodigoCompra.Text != String.Empty &&
                txtNombreCompania.Text != String.Empty &&
                txtCodigoProducto.Text != String.Empty &&
                nuCantidadProducto.Value != 0 &&
                txtPrecio.Text != String.Empty)
            {
                try
                {
                    producto agregarProducto = new producto();

                    agregarProducto.codigoProducto = txtCodigoProducto.Text;
                    agregarProducto.cantidadProducto = Convert.ToInt32(nuCantidadProducto.Value);

                    // Verifica que no haya producto repetidos
                    bool verificarProductoLista = listaProducto.Any(x => x.codigoProducto == txtCodigoProducto.Text);

                    // true existe
                    // false no existe
                    if (!verificarProductoLista)
                    {
                        listaProducto.Add(agregarProducto);

                        dgvCompraProveedor.Rows.Add(agregarProducto.codigoProducto, agregarProducto.cantidadProducto);
                        lblCantidad.Text = "Hay " + listaProducto.Count.ToString() + " Productos";

                        MessageBox.Show("La compra al proveedor se agrego a la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigoProducto.Text = String.Empty;
                        nuCantidadProducto.Value = 0;

                        txtCodigoProducto.Focus();
                    }

                    else
                    {
                        MessageBox.Show("No se ha podido agregar el producto porque ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el encargo del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // En caso de que exista uno o mas campos vacios
            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Se establece el foco
                txtCodigoProducto.Focus();
            }
        }

        private void preInsertarCompraProveedor(string codigo_producto, int cantidad_producto, bool band)
        {
            // Se crea un objeto cliente
            objCompraProveedorC = new CompraProveedorC();

            // Se le asignan los valores
            objCompraProveedorC.CodCompra = txtCodigoCompra.Text;
            objCompraProveedorC.NombreCompania = txtNombreCompania.Text;
            objCompraProveedorC.CodProducto = codigo_producto;
            objCompraProveedorC.Cantidad = cantidad_producto;
            objCompraProveedorC.Precio = double.Parse(txtPrecio.Text);
            objCompraProveedorC.Band = band;


            objCompraProveedorController = new CompraProveedorController(objCompraProveedorC);

            objCompraProveedorController.insertarCompraProveedor();
        }

        private void verificarCompraProveedor()
        {
            int cuantosProductos = listaProducto.Count;

            if (cuantosProductos > 0)
            {
                for (int i = 0; i < cuantosProductos; i++)
                {
                    if (i == 0)
                    {
                        // Invocamos al metodo
                        preInsertarCompraProveedor(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, true);
                    }

                    else
                    {
                        preInsertarCompraProveedor(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, false);
                    }
                }

                txtCodigoProducto.Focus();
            }

            else
            {
                // sin productos
                MessageBox.Show("No hay productos");
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCompraProveedor();
                MessageBox.Show("Compra al proveedor guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el pedido al proveedor.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigoCompra.Text = String.Empty;
            txtNombreCompania.Text = String.Empty;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;
            txtPrecio.Text = String.Empty;

            dgvCompraProveedor.Rows.Clear();

            btnNuevo.Focus();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {
            // Se crea un objeto para abrir el formulario
            SubmenuProductos productos = new SubmenuProductos();
            productos.ShowDialog();

            if (String.IsNullOrEmpty(ProductosC.CodProducto) == false)
            {
                txtCodigoProducto.Text = ProductosC.CodProducto;

                lblProducto.Text = "Cambiar producto";

                nuCantidadProducto.Focus();
            }

            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarProductoLista_Click(object sender, EventArgs e)
        {
            if (dgvCompraProveedor.Rows.Count > 0)
            {
                listaProducto.RemoveAt(dgvCompraProveedor.SelectedRows[0].Index);
                dgvCompraProveedor.Rows.RemoveAt(dgvCompraProveedor.SelectedRows[0].Index);

                MessageBox.Show("El producto se quito de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No hay ningun producto para quitar de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

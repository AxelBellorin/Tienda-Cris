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
using TRCAplicacion.Controllers.EncargoCliente;

using TRCAplicacion.Controllers.EstadoEncargo;
using TRCAplicacion.Controllers.TipoPago;

using TRCAplicacion.Controllers.Productos;

using TRCAplicacion.GUI.MenuOperaciones.Otros;

namespace TRCAplicacion.GUI.MenuOperaciones
{
    public partial class SubmenuEncargoCliente : Form
    {
        EncargoClienteC objEncargoClienteC = null;
        EncargoClienteController objEncargoClienteController = null;
        DataTable dt = null;

        //ProductosC objProductosC = null;

        private struct producto
        {
            public string codigoProducto;
            public int cantidadProducto;
        }

        private List<producto> listaProducto = new List<producto>();  

        public SubmenuEncargoCliente()
        {
            InitializeComponent();
        }

        private void SubmenuEncargoCliente_Load(object sender, EventArgs e)
        {

        }

        private void preInsertarEncargoCliente(string codigo_producto, int cantidad_producto, bool band)
        {
            // Se crea un objeto cliente
            objEncargoClienteC = new EncargoClienteC();

            // Se le asignan los valores
            objEncargoClienteC.CodigoEncargo = txtCodigoEncargo.Text;
            objEncargoClienteC.EstadoEncargo = cbEstadoEncargo.Text;
            objEncargoClienteC.CedulaCliente = mtbCedula.Text;
            objEncargoClienteC.TipoPago = cbTipoPago.Text;
            objEncargoClienteC.CodigoProducto = codigo_producto;
            objEncargoClienteC.CantidadProducto = cantidad_producto;
            objEncargoClienteC.Band = band;

            objEncargoClienteController = new EncargoClienteController(objEncargoClienteC);

            objEncargoClienteController.insertarEncargoCliente();
        }

        private void verificarEncargoCliente()
        {
            int cuantosProductos = listaProducto.Count;

            if (cuantosProductos > 0)
            {
                for (int i = 0; i < cuantosProductos; i++)
                {
                    if (i == 0)
                    {
                        // Invocamos al metodo
                        preInsertarEncargoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, true);
                    }

                    else
                    {
                        preInsertarEncargoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, false);
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
                verificarEncargoCliente();
                MessageBox.Show("Encargo del cliente guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el encargo del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigoEncargo.Text = String.Empty;
            cbEstadoEncargo.SelectedIndex = 0;
            mtbCedula.Text = String.Empty;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            dgvEncargoCliente.Rows.Clear();

            btnNuevo.Focus();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEncargoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Para mostrar el estado encargo en el combo
        EstadoEncargoC objEstadoEncargoC = null;
        EstadoEncargoController objEstadoEncargoController = null;
        DataTable dtEstadoEncargo = null;

        private void mostrarEstadoEncargoComboBox()
        {
            cbEstadoEncargo.Items.Clear();

            objEstadoEncargoC = new EstadoEncargoC();
            objEstadoEncargoController = new EstadoEncargoController(objEstadoEncargoC);

            dtEstadoEncargo = new DataTable();
            dtEstadoEncargo = objEstadoEncargoController.mostrarEstadoEncargo();

            cbEstadoEncargo.Items.Add("(Seleccione)");

            if (dtEstadoEncargo.Rows.Count > 0)
            {
                for (int i = 0; i < dtEstadoEncargo.Rows.Count; i++)
                {
                    cbEstadoEncargo.Items.Add(dtEstadoEncargo.Rows[i][0].ToString());
                }
            }

            cbEstadoEncargo.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        // Para mostrar el tipo de pago en el combo
        TipoPagoC objTipoPagoC = null;
        TipoPagoController objTipoPagoController = null;
        DataTable dtTipoPago = null;
        private void mostrarTipoPagoComboBox()
        {
            cbTipoPago.Items.Clear();

            objTipoPagoC = new TipoPagoC();
            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            dtTipoPago = new DataTable();
            dtTipoPago = objTipoPagoController.mostrarTipoPago();

            cbTipoPago.Items.Add("(Seleccione)");

            if (dtTipoPago.Rows.Count > 0)
            {
                for (int i = 0; i < dtTipoPago.Rows.Count; i++)
                {
                    cbTipoPago.Items.Add(dtTipoPago.Rows[i][0].ToString());
                }
            }

            cbTipoPago.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void Limpiar()
        {
            txtCodigoEncargo.Text = String.Empty;
            cbEstadoEncargo.SelectedIndex = 0;
            mtbCedula.Text = String.Empty;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            txtCodigoEncargo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarEstadoEncargoComboBox();

            mostrarTipoPagoComboBox();

            listaProducto.Clear();

            Limpiar();
        }

        private void btnAgregarProductoLista_Click(object sender, EventArgs e)
        {
            if (txtCodigoEncargo.Text != String.Empty &&
                cbEstadoEncargo.SelectedIndex != 0 &&
                mtbCedula.MaskFull &&
                cbTipoPago.SelectedIndex != 0 &&
                txtCodigoProducto.Text != String.Empty &&
                nuCantidadProducto.Value != 0)
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

                        dgvEncargoCliente.Rows.Add(agregarProducto.codigoProducto, agregarProducto.cantidadProducto);
                        lblCantidad.Text = "Hay " + listaProducto.Count.ToString() + " Productos";

                        MessageBox.Show("El producto se agrego a la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigoProducto.Text = String.Empty;
                        nuCantidadProducto.Value = 0;

                        lblProducto.Text = "Seleccionar otro producto";
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
            if (dgvEncargoCliente.Rows.Count > 0)
            {
                listaProducto.RemoveAt(dgvEncargoCliente.SelectedRows[0].Index);
                dgvEncargoCliente.Rows.RemoveAt(dgvEncargoCliente.SelectedRows[0].Index);

                MessageBox.Show("El producto se quito de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No hay ningun producto para quitar de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

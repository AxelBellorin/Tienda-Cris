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
using TRCAplicacion.Controllers.PedidoCliente;

using TRCAplicacion.Controllers.TipoPago;
using TRCAplicacion.Controllers.PuntoReunion;

using TRCAplicacion.Controllers.Productos;

using TRCAplicacion.GUI.MenuOperaciones.Otros;

namespace TRCAplicacion.GUI.MenuOperaciones
{
    public partial class SubmenuPedidoCliente : Form
    {
        PedidoClienteC objPedidoClienteC = null;
        PedidoClienteController objPedidoClienteController = null;
        DataTable dt = null;

        // Pais
        PaisC objPaisC = null;
        PaisController objPaisController = null;
        DataTable dtPais = null;

        // Departamento
        DepartamentoC objDepartamentoC = null;
        DepartamentoController objDepartamentoController = null;
        DataTable dtDepartamento = null;

        // Municipio
        MunicipioC objMunicipioC = null;
        MunicipioController objMunicipioController = null;
        DataTable dtMunicipio = null;

        // Punto reunion
        PuntoReunionC objPuntoReunionC = null;
        PuntoReunionController objPuntoReunionController = null;
        DataTable dtPuntoReunion = null;

        // Tipo de pago
        TipoPagoC objTipoPagoC = null;
        TipoPagoController objTipoPagoController = null;
        DataTable dtTipoPago = null;

        // Se crea un struct producto
        private struct producto
        {
            public string codigoProducto;
            public int cantidadProducto;
        }

        // Se crea un objeto lista de tipo producto
        private List<producto> listaProducto = new List<producto>();

        public SubmenuPedidoCliente()
        {
            InitializeComponent();
        }

        private void SubmenuPedidoCliente_Load(object sender, EventArgs e)
        {

        }

        #region Mostrar los combo

        private void mostrarPaisCombo()
        {
            cbPais.Items.Clear();

            objPaisC = new PaisC();
            objPaisController = new PaisController(objPaisC);

            dtPais = new DataTable();
            dtPais = objPaisController.mostrarPaises();

            cbPais.Items.Add("(Seleccione)");

            if (dtPais.Rows.Count > 0)
            {
                for (int i = 0; i < dtPais.Rows.Count; i++)
                {
                    cbPais.Items.Add(dtPais.Rows[i][0].ToString());
                }
            }

            cbPais.SelectedIndex = 0;
        }

        private void mostrarDepartamentoCombo()
        {
            if (cbPais.SelectedItem != null)
            {
                cbDepartamento.Items.Clear();

                objDepartamentoC = new DepartamentoC();
                objDepartamentoController = new DepartamentoController(objDepartamentoC);

                dtDepartamento = new DataTable();

                dtDepartamento = objDepartamentoController.mostrarDepartamentos(cbPais.SelectedItem.ToString());

                if (dtDepartamento.Rows.Count > 0)
                {
                    cbDepartamento.Items.Add("(Seleccione)");
                    for (int i = 0; i < dtDepartamento.Rows.Count; i++)
                    {
                        cbDepartamento.Items.Add(dtDepartamento.Rows[i][0].ToString());
                    }
                    cbDepartamento.SelectedIndex = 0;
                }

                else
                {
                    MessageBox.Show("No se encontraron departamentos para el pais\n\"" + cbPais.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un pais", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mostrarMunicipiosCombo()
        {
            if (cbDepartamento.SelectedItem != null)
            {
                cbMunicipio.Items.Clear();

                objMunicipioC = new MunicipioC();
                objMunicipioController = new MunicipioController(objMunicipioC);

                dtMunicipio = new DataTable();
                dtMunicipio = objMunicipioController.mostrarMunicipios(cbDepartamento.SelectedItem.ToString(), cbPais.SelectedItem.ToString());

                if (dtMunicipio.Rows.Count > 0)
                {
                    cbMunicipio.Items.Add("(Seleccione)");
                    for (int i = 0; i < dtMunicipio.Rows.Count; i++)
                    {
                        cbMunicipio.Items.Add(dtMunicipio.Rows[i][0].ToString());
                    }
                    cbMunicipio.SelectedIndex = 0;
                }

                else
                {
                    MessageBox.Show("No se encontraron municipios para el departamento\n\"" + cbDepartamento.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un departamento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void mostrarPuntoReunionCombo()
        {
            if (cbMunicipio.SelectedItem != null)
            {
                cbPuntoReunion.Items.Clear();

                objPuntoReunionC = new PuntoReunionC();
                objPuntoReunionController = new PuntoReunionController(objPuntoReunionC);

                dtPuntoReunion = new DataTable();

                dtPuntoReunion = objPuntoReunionController.mostrarPuntosReunion(cbMunicipio.SelectedItem.ToString(), cbDepartamento.SelectedItem.ToString(), cbPais.SelectedItem.ToString());

                if (dtPuntoReunion.Rows.Count > 0)
                {
                    cbPuntoReunion.Items.Add("(Seleccione)");
                    for (int i = 0; i < dtPuntoReunion.Rows.Count; i++)
                    {
                        cbPuntoReunion.Items.Add(dtPuntoReunion.Rows[i][0].ToString());
                    }
                    cbPuntoReunion.SelectedIndex = 0;
                }

                else
                {
                    MessageBox.Show("No se encontraron puntos de reunion para el municipio\n\"" + cbMunicipio.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un municipio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mostrarTipoPagoComboBox()
        {
            cbTipoPago.Items.Clear();

            objTipoPagoC = new TipoPagoC();
            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            dtTipoPago = new DataTable();
            dtTipoPago = objTipoPagoController.mostrarTipoPago();

            if (dtTipoPago.Rows.Count > 0)
            {
                cbTipoPago.Items.Add("(Seleccione)");
                for (int i = 0; i < dtTipoPago.Rows.Count; i++)
                {
                    cbTipoPago.Items.Add(dtTipoPago.Rows[i][0].ToString());
                }
                cbTipoPago.SelectedIndex = 0;
            }
        }

        #endregion

        private void Limpiar()
        {
            txtCodigoPedido.Text = String.Empty;
            dtpFechaEntrega.Value = DateTime.Now;
            mtbCedula.Text = String.Empty;
            //cbPuntoReunion.SelectedIndex = 0;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            txtCodigoPedido.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarPaisCombo();

            mostrarTipoPagoComboBox();

            listaProducto.Clear();

            Limpiar();
        }

        private void btnAgregarProductoLista_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedido.Text != String.Empty &&
                // cbEstadoEncargo.SelectedIndex != 0 &&
                mtbCedula.MaskFull &&
                cbPais.SelectedIndex != 0 &&
                cbTipoPago.SelectedIndex != 0 &&
                txtCodigoProducto.Text != String.Empty &&
                nuCantidadProducto.Value != 0)
            {
                if (ProductosC.StockProducto >= nuCantidadProducto.Value)
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

                            dgvPedidoCliente.Rows.Add(agregarProducto.codigoProducto, agregarProducto.cantidadProducto);
                            lblCantidad.Text = "Hay " + listaProducto.Count.ToString() + " Productos";

                            MessageBox.Show("El pedido del cliente se agrego a la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show("No se ha podido guardar el pedido del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("No se ha podido agregar el producto porque no hay suficiente stock ("+ ProductosC.StockProducto.ToString() +")", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void verificarPedidoCliente()
        {
            int cuantosProductos = listaProducto.Count;

            if (cuantosProductos > 0)
            {
                for (int i = 0; i < cuantosProductos; i++)
                {
                    if (i == 0)
                    {
                        // Invocamos al metodo
                        preInsertarPedidoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, true);
                    }

                    else
                    {
                        preInsertarPedidoCliente(listaProducto[i].codigoProducto, listaProducto[i].cantidadProducto, false);
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

        private void preInsertarPedidoCliente(string codigo_producto, int cantidad_producto, bool band)
        {
            // Se crea un objeto pedido cliente
            objPedidoClienteC = new PedidoClienteC();

            // Se le asignan los valores
            objPedidoClienteC.CodigoPedido = txtCodigoPedido.Text;
            objPedidoClienteC.FechaEntrega = dtpFechaEntrega.Value;
            objPedidoClienteC.Cedula = mtbCedula.Text;
            objPedidoClienteC.PuntoReunion = cbPuntoReunion.Text;
            objPedidoClienteC.TipoPago = cbTipoPago.Text;
            objPedidoClienteC.CodigoProducto = codigo_producto;
            objPedidoClienteC.CantidadProducto = cantidad_producto;
            objPedidoClienteC.Band = band;

            objPedidoClienteController = new PedidoClienteController(objPedidoClienteC);

            objPedidoClienteController.insertarPedidoCliente();
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                verificarPedidoCliente();
                MessageBox.Show("Pedido del cliente guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el pedido del cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigoPedido.Text = String.Empty;
            mtbCedula.Text = String.Empty;
            cbTipoPago.SelectedIndex = 0;
            txtCodigoProducto.Text = String.Empty;
            nuCantidadProducto.Value = 0;

            dgvPedidoCliente.Rows.Clear();

            btnNuevo.Focus();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex != 0)
            {
                mostrarDepartamentoCombo();
                cbMunicipio.Items.Clear();
                cbPuntoReunion.Items.Clear();
            }
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedIndex != 0)
            {
                mostrarMunicipiosCombo();
                cbPuntoReunion.Items.Clear();
            }
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMunicipio.SelectedIndex != 0)
            {
                mostrarPuntoReunionCombo();
            }
        }

        private void cbPuntoReunion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {
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
            if (dgvPedidoCliente.Rows.Count > 0)
            {
                listaProducto.RemoveAt(dgvPedidoCliente.SelectedRows[0].Index);
                dgvPedidoCliente.Rows.RemoveAt(dgvPedidoCliente.SelectedRows[0].Index);

                MessageBox.Show("El producto se quito de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No hay ningun producto para quitar de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

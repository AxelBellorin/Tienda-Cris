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
using TRCAplicacion.Controllers.Producto;

using TRCAplicacion.Controllers.Categoria;
using TRCAplicacion.Controllers.Talla;
using TRCAplicacion.Controllers.Marca;

namespace TRCAplicacion.GUI.MenuCatalogos
{
    public partial class SubmenuProducto : Form
    {
        ProductoC objProductoC = null;
        ProductoController objProductoController = null;
        DataTable dt = null;

        public SubmenuProducto()
        {
            InitializeComponent();
        }

        #region Metodos no async

        private void mostrarGridProducto()
        {
            dgvProducto.Rows.Clear();

            objProductoC = new ProductoC();
            objProductoController = new ProductoController(objProductoC);

            dt = new DataTable();
            dt = objProductoController.mostrarProductos();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvProducto.Rows.Add(dt.Rows[i][0].ToString(),
                                         dt.Rows[i][1].ToString(),
                                         dt.Rows[i][2].ToString(),
                                         dt.Rows[i][3].ToString(),
                                         dt.Rows[i][4].ToString(),
                                         dt.Rows[i][5].ToString(),
                                         dt.Rows[i][6].ToString());
                }
            }
            
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarProducto()
        {
            // Se crea un objeto producto
            objProductoC = new ProductoC();

            // Se le asignan los valores
            objProductoC.CodProducto = txtCodProducto.Text;
            objProductoC.Categoria = cbCategoria.Text;
            objProductoC.Descripcion = txtDescripcion.Text;
            objProductoC.Talla = cbTalla.Text;
            objProductoC.Marca = cbMarca.Text;

            objProductoController = new ProductoController(objProductoC);

            try
            {
                objProductoController.insertarProducto();
                //MessageBox.Show("Se ha guardado el producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el producto.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void SubmenuProducto_Load(object sender, EventArgs e)
        {
            // Cargar datos en el grid ActualizarGrid();

            txtBuscar.Focus();

            mostrarGridProducto();
        }

        private void AcualizarGrid()
        { }

        private void Limpiar()
        {
            txtCodProducto.Text = String.Empty;
            cbCategoria.SelectedIndex = 0;
            txtDescripcion.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            cbTalla.SelectedIndex = 0;
            cbMarca.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != String.Empty)
            {
                // Buscar

                // Busqueda Exitosa
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }

            else
            {
                btnCancelar.PerformClick();
                MessageBox.Show("Nada para buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();
            }
        }

        // Para mostrar las categorias en el combo
        CategoriaC objCategoriaC = null;
        CategoriaController objCategoriaController = null;
        DataTable dtCategoria = null;

        private void mostrarCategoriasComboBox()
        {
            cbCategoria.Items.Clear();

            objCategoriaC = new CategoriaC();
            objCategoriaController = new CategoriaController(objCategoriaC);

            dtCategoria = new DataTable();
            dtCategoria = objCategoriaController.mostrarCategorias();

            cbCategoria.Items.Add("(Seleccione)");

            if (dtCategoria.Rows.Count > 0)
            {
                for (int i = 0; i < dtCategoria.Rows.Count; i++)
                {
                    cbCategoria.Items.Add(dtCategoria.Rows[i][0].ToString());
                }
            }

            cbCategoria.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        // Para mostrar las tallas en el combo
        TallaC objTallaC = null;
        TallaController objTallaController = null;
        DataTable dtTalla = null;
        private void mostrarTallasComboBox()
        {
            cbTalla.Items.Clear();

            objTallaC = new TallaC();
            objTallaController = new TallaController(objTallaC);

            dtTalla = new DataTable();
            dtTalla = objTallaController.mostrarTallas();

            cbTalla.Items.Add("(Seleccione)");

            if (dtTalla.Rows.Count > 0)
            {
                for (int i = 0; i < dtTalla.Rows.Count; i++)
                {
                    cbTalla.Items.Add(dtTalla.Rows[i][0].ToString());
                }
            }

            cbTalla.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        // Para mostrar las marcas en el combo
        MarcaC objMarcaC = null;
        MarcaController objMarcaController = null;
        DataTable dtMarca = null;
        private void mostrarMarcasComboBox()
        {
            cbMarca.Items.Clear();

            objMarcaC = new MarcaC();
            objMarcaController = new MarcaController(objMarcaC);

            dtMarca = new DataTable();
            dtMarca = objMarcaController.mostrarMarcas();

            cbMarca.Items.Add("(Seleccione)");

            if (dtMarca.Rows.Count > 0)
            {
                for (int i = 0; i < dtMarca.Rows.Count; i++)
                {
                    cbMarca.Items.Add(dtMarca.Rows[i][0].ToString());
                }
            }

            cbMarca.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando";

            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            txtCodProducto.Focus();

            cbCategoria.Focus();

            // Cargar categorias, tallas y marcas en combobox

            mostrarCategoriasComboBox();
            mostrarTallasComboBox();
            mostrarMarcasComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodProducto.Text != String.Empty &&
                cbCategoria.SelectedIndex != 0 &&
                txtDescripcion.Text != String.Empty &&
                cbTalla.SelectedIndex != 0 &&
                cbMarca.SelectedIndex != 0)
            {
                preInsertarProducto();
                mostrarGridProducto();

                Limpiar();

                gbLlenadoEdicion.Enabled = false;

                btnGuardar.Enabled = false;

                mostrarGridProducto();
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbCategoria.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            gbLlenadoEdicion.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            btnCancelar.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (dgvProducto.SelectedRows.Count == 1)
            //{

            //}

            //else
            //{
            //    MessageBox.Show("Por favor, selecciona una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // rv
            if (dgvProducto.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Quieres borrar el producto seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Producto borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblEditarTallas_Click(object sender, EventArgs e)
        {
            
        }

        private void lblEditarMarcas_Click(object sender, EventArgs e)
        {
            
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

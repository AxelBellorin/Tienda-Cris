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
using TRCAplicacion.Controllers.Categoria;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuCategoria : Form
    {
        CategoriaC objCategoriaC = null;
        CategoriaController objCategoriaController = null;
        DataTable dt = null;

        public SubmenuCategoria()
        {
            InitializeComponent();
        }

        private void preInsertarCategoria()
        {
            // Se crea un objeto cargo
            objCategoriaC = new CategoriaC();

            // Se le asignan los valores
            objCategoriaC.Nombre = txtNombre.Text;

            objCategoriaController = new CategoriaController(objCategoriaC);

            try
            {
                objCategoriaController.insertarCategoria();
                MessageBox.Show("Categoria guardada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar la categoria.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preActualizarCategoria()
        {
            // Se crea un objeto cargo
            objCategoriaC = new CategoriaC();

            // Se le asignan los valores
            objCategoriaC.Nombre = txtNombre.Text;

            objCategoriaController = new CategoriaController(objCategoriaC);

            try
            {
                objCategoriaController.actualizarCategoria(dgvCategoria.SelectedCells[0].Value.ToString());
                MessageBox.Show("Categoria editada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar la categoria.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preEliminarCategoria()
        {
            // Se crea un objeto cargo
            objCategoriaC = new CategoriaC();

            objCategoriaController = new CategoriaController(objCategoriaC);

            try
            {
                objCategoriaController.eliminarCategoria(dgvCategoria.SelectedCells[0].Value.ToString());
                MessageBox.Show("Categoria borrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar la categoria.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando";

            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardarEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar la categoria seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    preEliminarCategoria();

                    mostrarGridCategoria();
                }

                else
                {
                    MessageBox.Show("Operacion cancelada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                try
                {
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarCategoria(); 
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarCategoria();                        
                    }

                    mostrarGridCategoria();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar la categoria.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

                btnGuardarEditar.Enabled = false;

                Limpiar();
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvCategoria.SelectedCells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            btnGuardarEditar.Enabled = true;
            txtNombre.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmenuCategoria_Load(object sender, EventArgs e)
        {
            mostrarGridCategoria();
        }

        private void mostrarGridCategoria()
        {
            dgvCategoria.Rows.Clear();

            objCategoriaC = new CategoriaC();
            objCategoriaController = new CategoriaController(objCategoriaC);

            dt = new DataTable();
            dt = objCategoriaController.mostrarCategorias();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCategoria.Rows.Add(dt.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

    }
}

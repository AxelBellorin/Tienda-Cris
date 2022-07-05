using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using TRCAplicacion.Controllers.Cargo;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuCargo : Form
    {
        CargoC objCargoC = null;
        CargoController objCargoController = null;
        DataTable dt = null;

        public SubmenuCargo()
        {
            InitializeComponent();
        }

        #region Metodos no async

        // Revisado //
        private void mostrarGridCargo()
        {
            dgvCargo.Rows.Clear();

            objCargoC = new CargoC();
            objCargoController = new CargoController(objCargoC);

            dt = new DataTable();
            dt = objCargoController.mostrarCargos();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCargo.Rows.Add(dt.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarCargo()
        {
            // Se crea un objeto cargo
            objCargoC = new CargoC();

            // Se le asignan los valores
            objCargoC.Nombre = txtNombre.Text;

            objCargoController = new CargoController(objCargoC);

            try
            {
                objCargoController.insertarCargo();
                MessageBox.Show("Cargo guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el cargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Revisado //
        private void preActualizarCargo()
        {
            // Se crea un objeto cargo
            objCargoC = new CargoC();

            // Se le asignan los valores
            objCargoC.Nombre = txtNombre.Text;

            objCargoController = new CargoController(objCargoC);

            try
            {
                objCargoController.actualizarCargo(dgvCargo.SelectedCells[0].Value.ToString());
                MessageBox.Show("Cargo editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar el cargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Revisado //
        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvCargo.SelectedCells[0].Value.ToString();
        }

        // Revisado //
        private void preEliminarCargo()
        {
            // Se crea un objeto cargo
            objCargoC = new CargoC();

            //// Se le asignan los valores
            //objCargoC.Nombre = txtNombre.Text;

            objCargoController = new CargoController(objCargoC);

            try
            {
                objCargoController.eliminarCargo(dgvCargo.SelectedCells[0].Value.ToString());
                MessageBox.Show("Cargo borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar el cargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Otros metodos

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        #endregion

        private void SubmenuCargo_Load(object sender, EventArgs e)
        {
            mostrarGridCargo();

            txtBuscar.Focus();
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                if (gbLlenadoEdicion.Text == "Ingresando")
                {
                    preInsertarCargo();
                }

                else if (gbLlenadoEdicion.Text == "Editando")
                {
                    preActualizarCargo();
                }

                mostrarGridCargo();

                btnGuardarEditar.Enabled = false;

                Limpiar();
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            btnGuardarEditar.Enabled = true;
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCargo.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar el cargo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    preEliminarCargo();

                    mostrarGridCargo();
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

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }
    }
}

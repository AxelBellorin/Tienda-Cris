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
using TRCAplicacion.Controllers.Talla;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuTalla : Form
    {
        TallaC objTallaC = null;
        TallaController objTallaController = null;
        DataTable dt = null;

        public SubmenuTalla()
        {
            InitializeComponent();
        }

        #region Metodos no async

        // Revisado //
        private void mostrarGridTalla()
        {
            dgvTalla.Rows.Clear();

            objTallaC = new TallaC();
            objTallaController = new TallaController(objTallaC);

            dt = new DataTable();
            dt = objTallaController.mostrarTallas();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvTalla.Rows.Add(dt.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarTalla()
        {
            // Se crea un objeto talla
            objTallaC = new TallaC();

            // Se le asignan los valores
            objTallaC.Nombre = txtNombre.Text;

            objTallaController = new TallaController(objTallaC);

            try
            {
                objTallaController.insertarTalla();
                MessageBox.Show("Talla guardada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar la talla.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Revisado // hacer mejoras en metodo y controles
        private void preActualizarTalla()
        {
            // Se crea un objeto talla
            objTallaC = new TallaC();

            // Se le asignan los valores
            objTallaC.Nombre = txtNombre.Text;

            objTallaController = new TallaController(objTallaC);

            try
            {
                objTallaController.actualizarTalla(dgvTalla.SelectedCells[0].Value.ToString());
                MessageBox.Show("Talla editada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar la talla.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preEliminarTalla()
        {
            // Se crea un objeto talla
            objTallaC = new TallaC();

            objTallaController = new TallaController(objTallaC);

            try
            {
                objTallaController.eliminarTalla(dgvTalla.SelectedCells[0].Value.ToString());
                MessageBox.Show("Talla borrada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar la talla.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvTalla.SelectedCells[0].Value.ToString();
        }

        #endregion

        #region Otros metodos

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        #endregion

        private void SubmenuTalla_Load(object sender, EventArgs e)
        {
            mostrarGridTalla();

            txtNombre.Focus();
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

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                try
                {
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarTalla();  
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarTalla();
                    }

                    mostrarGridTalla();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar la talla.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

                btnGuardarEditar.Enabled = false;

                Limpiar();

                gbLlenadoEdicion.Enabled = false;
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
            }
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

        // eliminarConCedula = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // new
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            btnGuardarEditar.Enabled = true;
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTalla.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar la talla seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    preEliminarTalla();                        
                    mostrarGridTalla();
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

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }
    }
}

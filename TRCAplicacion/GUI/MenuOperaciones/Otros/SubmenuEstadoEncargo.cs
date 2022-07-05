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
using TRCAplicacion.Controllers.EstadoEncargo;

namespace TRCAplicacion.GUI.MenuOperaciones.Otros
{
    public partial class SubmenuEstadoEncargo : Form
    {
        EstadoEncargoC objEstadoEncargoC = null;
        EstadoEncargoController objEstadoEncargoController = null;
        DataTable dt = null;

        public SubmenuEstadoEncargo()
        {
            InitializeComponent();
        }

        private void mostrarGridEstadoEncargo()
        {
            dgvEstadoEncargo.Rows.Clear();

            objEstadoEncargoC = new EstadoEncargoC();
            objEstadoEncargoController = new EstadoEncargoController(objEstadoEncargoC);

            dt = new DataTable();
            dt = objEstadoEncargoController.mostrarEstadoEncargo();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvEstadoEncargo.Rows.Add(dt.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
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

            txtNombre.Focus(); gbLlenadoEdicion.Text = "Ingresando";

            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardarEditar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombre.Focus();
        }

        private void SubmenuEstadoEncargo_Load(object sender, EventArgs e)
        {
            mostrarGridEstadoEncargo();

            txtNombre.Focus();
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvEstadoEncargo.SelectedCells[0].Value.ToString();
        }


        private void preInsertarEstadoEncargo()
        {
            // Se crea un objeto estado encargo
            objEstadoEncargoC = new EstadoEncargoC();

            // Se le asignan los valores
            objEstadoEncargoC.Nombre = txtNombre.Text;

            objEstadoEncargoController = new EstadoEncargoController(objEstadoEncargoC);

            try
            {
                objEstadoEncargoController.insertarEstadoEncargo();
                MessageBox.Show("Estado encargo guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el estado encargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preActualizarEstadoEncargo()
        {
            // Se crea un objeto estado encargo
            objEstadoEncargoC = new EstadoEncargoC();

            // Se le asignan los valores
            objEstadoEncargoC.Nombre = txtNombre.Text;

            objEstadoEncargoController = new EstadoEncargoController(objEstadoEncargoC);

            try
            {
                objEstadoEncargoController.actualizarEstadoEncargo(dgvEstadoEncargo.SelectedCells[0].Value.ToString());
                MessageBox.Show("Estado encargo editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar el estado encargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preEliminarEstadoEncargo()
        {
            // Se crea un objeto estado encargo
            objEstadoEncargoC = new EstadoEncargoC();

            //// Se le asignan los valores
            //objCargoC.Nombre = txtNombre.Text;

            objEstadoEncargoController = new EstadoEncargoController(objEstadoEncargoC);

            try
            {
                objEstadoEncargoController.eliminarEstadoEncargo(dgvEstadoEncargo.SelectedCells[0].Value.ToString());
                MessageBox.Show("Se ha borrado el estado encargo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar el estado encargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                try
                {
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarEstadoEncargo();                        
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarEstadoEncargo();
                    }


                    mostrarGridEstadoEncargo();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el estado encargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

                Limpiar();
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Focus();
            }
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
            if (dgvEstadoEncargo.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar el estado encargo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        preEliminarEstadoEncargo();

                        MessageBox.Show("Estado encargo borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarGridEstadoEncargo();
                    }

                    catch (Exception Excepcion)
                    {
                        MessageBox.Show("No se ha podido borrar el estado encargo.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw;
                    }
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

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {

        }
    }
}

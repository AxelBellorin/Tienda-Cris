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
using TRCAplicacion.Controllers.TipoPago;

namespace TRCAplicacion.GUI.MenuOperaciones.Otros
{
    public partial class SubmenuTipoPago : Form
    {
        TipoPagoC objTipoPagoC = null;
        TipoPagoController objTipoPagoController = null;
        DataTable dt = null;

        public SubmenuTipoPago()
        {
            InitializeComponent();
        }

        private void mostrarGridTipoPago()
        {
            dgvTipoPago.Rows.Clear();

            objTipoPagoC = new TipoPagoC();
            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            dt = new DataTable();
            dt = objTipoPagoController.mostrarTipoPago();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvTipoPago.Rows.Add(dt.Rows[i][0].ToString());
                }
            }

            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void preInsertarTipoPago()
        {
            // Se crea un objeto talla
            objTipoPagoC = new TipoPagoC();

            // Se le asignan los valores
            objTipoPagoC.Nombre = txtNombre.Text;

            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            try
            {
                objTipoPagoController.insertarTipoPago();
                MessageBox.Show("Tipo de pago guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el tipo de pago.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Revisado // hacer mejoras en metodo y controles
        private void preActualizarTipoPago()
        {
            // Se crea un objeto talla
            objTipoPagoC = new TipoPagoC();

            // Se le asignan los valores
            objTipoPagoC.Nombre = txtNombre.Text;

            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            try
            {
                objTipoPagoController.actualizarTipoPago(dgvTipoPago.SelectedCells[0].Value.ToString());
                MessageBox.Show("Tipo de pago editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar el tipo de pago.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preEliminarTipoPago()
        {
            // Se crea un objeto talla
            objTipoPagoC = new TipoPagoC();

            objTipoPagoController = new TipoPagoController(objTipoPagoC);

            try
            {
                objTipoPagoController.eliminarTipoPago(dgvTipoPago.SelectedCells[0].Value.ToString());
                MessageBox.Show("Se ha borrado el tipo de pago", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar el tipo de pago.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarControlesParaActualizar()
        {
            txtNombre.Text = dgvTipoPago.SelectedCells[0].Value.ToString();
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
        }

        private void SubmenuTipoPago_Load(object sender, EventArgs e)
        {
            mostrarGridTipoPago();

            txtBuscar.Focus();
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTipoPago.SelectedCells.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar el tipo de pago seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        preEliminarTipoPago();

                        MessageBox.Show("Tipo de pago borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarGridTipoPago();
                    }

                    catch (Exception Excepcion)
                    {
                        MessageBox.Show("No se ha podido borrar el tipo de pago.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                try
                {
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarTipoPago(); 
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarTipoPago();                 
                    }

                    mostrarGridTipoPago();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el tipo de pago.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

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

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            btnGuardarEditar.Enabled = true;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

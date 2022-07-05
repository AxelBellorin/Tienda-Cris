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
using TRCAplicacion.Controllers.Trabajador;
using TRCAplicacion.Controllers.Cargo;

namespace TRCAplicacion.GUI.MenuCatalogos
{
    public partial class SubmenuTrabajador : Form
    {
        public SubmenuTrabajador()
        {
            InitializeComponent();
        }

        TrabajadorC objTrabajadorC = null;
        TrabajadorController objTrabajadorController = null;
        DataTable dt = null;

        // Para mostrar los cargos en el combo
        CargoC objCargoC = null;
        CargoController objCargoController = null;
        DataTable dtCargo = null;

        private void mostrarCargoComboBox()
        {
            cbCargo.Items.Clear();

            objCargoC = new CargoC();
            objCargoController = new CargoController(objCargoC);

            dtCargo = new DataTable();
            dtCargo = objCargoController.mostrarCargos();

            cbCargo.Items.Add("(Seleccione)");

            if (dtCargo.Rows.Count > 0)
            {
                for (int i = 0; i < dtCargo.Rows.Count; i++)
                {
                    cbCargo.Items.Add(dtCargo.Rows[i][0].ToString());
                }
            }

            cbCargo.SelectedIndex = 0;
            // cantidad
            //lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        private void SubmenuTrabajador_Load(object sender, EventArgs e)
        {
            // Cargar datos en el grid ActualizarGrid();
            
            cbCargo.Items.Add("Seleccionar");
            cbCargo.SelectedIndex = 0;
            mostrarCargoComboBox();

            txtBuscar.Focus();
        }

        private void preInsertarTrabajador()
        {
            // Se crea un objeto trabajador
            objTrabajadorC = new TrabajadorC();

            // Se le asignan los valores
            objTrabajadorC.Nombres = txtNombres.Text;
            objTrabajadorC.Apellidos = txtApellidos.Text;
            objTrabajadorC.Cedula = mtbCedula.Text;
            objTrabajadorC.Telefono = mtbTelefono.Text;
            objTrabajadorC.Direccion = txtDireccion.Text;
            objTrabajadorC.Cargo = cbCargo.SelectedItem.ToString();
            objTrabajadorC.Usuario = txtUsuario.Text;
            objTrabajadorC.Contrasena = txtContrasena.Text;

            objTrabajadorController = new TrabajadorController(objTrabajadorC);

            try
            {
                objTrabajadorController.insertarTrabajador();
                MessageBox.Show("Se ha guardado el trabajador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el trabajador.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcualizarGrid()
        { }

        private void Limpiar()
        {
            txtNombres.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            mtbTelefono.Text = String.Empty;
            mtbCedula.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtContrasena.Text = String.Empty;
            cbCargo.SelectedIndex = 0;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando";

            txtBuscar.Text = String.Empty;

            gbLlenadoEdicion.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            txtNombres.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty &&
                txtApellidos.Text != String.Empty &&
                mtbTelefono.MaskFull &&
                mtbCedula.MaskFull &&
                txtDireccion.Text != String.Empty &&
                txtUsuario.Text != String.Empty &&
                txtContrasena.Text != String.Empty &&
                cbCargo.SelectedIndex != 0)
            {
                preInsertarTrabajador();
                
                Limpiar();

                gbLlenadoEdicion.Enabled = false;

                btnGuardar.Enabled = false;
            }

            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombres.Focus();
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
            //if (gridTrabajador.SelectedRows.Count == 1)
            //{

            //}

            //else
            //{
            //    MessageBox.Show("Por favor, selecciona una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //if (gridTrabajador.SelectedRows.Count == 1)
            //{
            //    if (MessageBox.Show("¿Quieres trabajador el producto seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Trabajador borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("Por favor, selecciona una fila para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}

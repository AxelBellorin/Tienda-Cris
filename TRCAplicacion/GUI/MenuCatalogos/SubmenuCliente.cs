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
using TRCAplicacion.Controllers.Cliente;

namespace TRCAplicacion.GUI.MenuCatalogos
{
    public partial class SubmenuCliente : Form
    {
        ClienteC objClienteC = null;
        ClienteController objClienteController = null;
        DataTable dt = null;

        public SubmenuCliente()
        {
            InitializeComponent();
        }

        #region Metodos async

        //private async Task<bool> mostrarGridClienteAsync()
        //{
        //    CheckForIllegalCrossThreadCalls = false;
        //    await Task.Run(
        //        () =>
        //        {
        //            NpgsqlConnection con = new NpgsqlConnection();
        //            Conexion.abrirConexion(con);

        //            NpgsqlCommand comando = new NpgsqlCommand();
        //            comando.CommandText = "mostrar_cliente";
        //            comando.CommandType = CommandType.StoredProcedure;
        //            comando.Connection = con;
        //            NpgsqlDataReader lector = comando.ExecuteReader();

        //            while (lector.Read())
        //            {
        //                dgvCliente.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
        //            }

        //            Conexion.cerrarConexion(con);
        //        }
        //    );
        //    return true;
        //}

        //private async Task<bool> insertarClienteAsync()
        //{
        //    CheckForIllegalCrossThreadCalls = false;
        //    await Task.Run(
        //        () =>
        //        {
        //            NpgsqlConnection con = new NpgsqlConnection();
        //            Conexion.abrirConexion(con);

        //            NpgsqlCommand comando = new NpgsqlCommand();
        //            comando.CommandText = "insertar_cliente";
        //            comando.CommandType = CommandType.StoredProcedure;
        //            comando.Connection = con;
        //            comando.Parameters.AddWithValue("@nombre", txtNombres.Text);
        //            comando.Parameters.AddWithValue("@apellido", txtApellidos.Text);
        //            comando.Parameters.AddWithValue("@cedula", mtbCedula.Text);
        //            comando.Parameters.AddWithValue("@telefono", mtbTelefono.Text);

        //            comando.ExecuteNonQuery();

        //            Conexion.cerrarConexion(con);
        //        }
        //    );
        //    return true;
        //}

        //private async Task<bool> eliminarClienteAsync(string cedula)
        //{
        //    CheckForIllegalCrossThreadCalls = false;
        //    await Task.Run(
        //        () =>
        //        {
        //            NpgsqlConnection con = new NpgsqlConnection();
        //            Conexion.abrirConexion(con);

        //            NpgsqlCommand comando = new NpgsqlCommand();
        //            comando.CommandText = "eliminar_cliente";
        //            comando.CommandType = CommandType.StoredProcedure;
        //            comando.Connection = con;
        //            comando.Parameters.AddWithValue("@cedula", cedula);

        //            comando.ExecuteNonQuery();

        //            Conexion.cerrarConexion(con);
        //        }
        //    );
        //    return true;
        //}

        #endregion

        #region Metodos no async

        /*
         * Revisado
         */
        private void mostrarGridCliente()
        {
            dgvCliente.Rows.Clear();

            objClienteC = new ClienteC();
            objClienteController = new ClienteController(objClienteC);

            dt = new DataTable();
            dt = objClienteController.mostrarClientes();
            
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCliente.Rows.Add(dt.Rows[i][0].ToString(),
                                        dt.Rows[i][1].ToString(),
                                        dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString());
                }
            }

            lblCantidad.Text = "Hay " + dt.Rows.Count.ToString() + " clientes";
        }

        // No listo
        // mostrarCliente()
        private void buscarCliente(string cedula)
        {
            //NpgsqlConnection con = new NpgsqlConnection();
            //Conexion.abrirConexion(con);

            //NpgsqlCommand comando = new NpgsqlCommand();
            //// Buscar el cliente

            //// Hacer un metodo para mostrar el cliente en el grid
        }

        #region Metodos Insertar, Actualizar, hacia la capa de controlador

        // Metodos que invocan a los metodos correspondientes en la Capa de Controlador
        /*
         * Revisados
         */
        private void preInsertarCliente()
        {
            // Se crea un objeto cliente
            objClienteC = new ClienteC();

            // Se le asignan los valores
            objClienteC.Nombres = txtNombres.Text;
            objClienteC.Apellidos = txtApellidos.Text;
            objClienteC.Cedula = mtbCedula.Text;
            objClienteC.Telefono = mtbTelefono.Text;

            objClienteController = new ClienteController(objClienteC);

            try
            {
                objClienteController.insertarCliente();
                MessageBox.Show("Cliente guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preActualizarCliente()
        {
            // Se crea un objeto cliente
            objClienteC = new ClienteC();

            // Se le asignan los valores
            objClienteC.Nombres = txtNombres.Text;
            objClienteC.Apellidos = txtApellidos.Text;
            objClienteC.Cedula = mtbCedula.Text;
            objClienteC.Telefono = mtbTelefono.Text;

            objClienteController = new ClienteController(objClienteC);

            try
            {
                objClienteController.actualizarCliente(dgvCliente.SelectedCells[2].Value.ToString());
                MessageBox.Show("Cliente editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar el cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preEliminarCliente()
        {
            // Se crea un objeto cliente
            objClienteC = new ClienteC();

            //// Se le asignan los valores
            //objClienteC.Cedula = mtbCedula.Text;

            objClienteController = new ClienteController(objClienteC);

            try
            {
                objClienteController.eliminarCliente(dgvCliente.SelectedCells[2].Value.ToString());
                MessageBox.Show("Cliente borrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar el cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        /*
         * Revisado
         * Mejorar la seleccion de la celda
         */

        // Metodo que llena los controles para actualizar
        private void llenarControlesParaActualizar()
        {
            txtNombres.Text = dgvCliente.SelectedCells[0].Value.ToString();
            txtApellidos.Text = dgvCliente.SelectedCells[1].Value.ToString();
            mtbCedula.Text = dgvCliente.SelectedCells[2].Value.ToString();
            mtbTelefono.Text = dgvCliente.SelectedCells[3].Value.ToString();
        }

        #endregion

        #region Otros metodos

        private void Limpiar()
        {
            txtNombres.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            mtbCedula.Text = String.Empty;
            mtbTelefono.Text = String.Empty;
        }

        #endregion

        // METODOS

        private void SubmenuCliente_Load(object sender, EventArgs e)
        {
            mostrarGridCliente();

            txtBuscar.Focus();
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

            txtNombres.Focus();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            btnCancelar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != String.Empty)
            {

            }

            else
            {
                btnCancelar.PerformClick();
                MessageBox.Show("Nada para buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != String.Empty &&
                txtApellidos.Text != String.Empty &&
                mtbCedula.MaskFull &&
                mtbTelefono.MaskFull)
            {
                try
                {
                    // Se verifica la operacion: ingresar o editar para invocar al metodo correspondiente
                    if (gbLlenadoEdicion.Text == "Ingresando")
                    {
                        preInsertarCliente();
                    }

                    else if (gbLlenadoEdicion.Text == "Editando")
                    {
                        preActualizarCliente();
                    }

                    mostrarGridCliente();
                }

                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el cliente.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnGuardarEditar.Enabled = false;

                Limpiar();

                gbLlenadoEdicion.Enabled = false;
            }

            // En caso de que exista uno o mas campos vacios
            else
            {
                MessageBox.Show("Por favor, llena todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Se establece el foco en el cuadro de texto Nombre
                txtNombres.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            txtBuscar.Focus();
        }

        // Boton MostrarOcultar
        // Es usado para mostrar u ocultar todos los registros en el DataGridView de Cliente
        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            //// Se establece un cursor de espera
            //Cursor = Cursors.WaitCursor;

            //// Se verifica si se van a mostrar u ocultar los registros
            //if (btnMostrarOcultar.Text == "Mostrar")
            //{
            //    mostrarGridCliente();

            //    btnMostrarOcultar.Text = "Ocultar";

            //    btnGuardarEditar.Enabled = false;
            //    btnCancelar.Enabled = false;

            //    if (gbDatos.Text == "Ingresando")
            //    {
            //        btnGuardarEditar.Enabled = true;
            //        btnCancelar.Enabled = true;

            //        btnEditar.Enabled = false;
            //        btnBorrar.Enabled = false;
            //    }

            //    else
            //    {
            //        btnEditar.Enabled = true;
            //        btnBorrar.Enabled = true;
            //    }

            //    btnRefrescar.Enabled = true;
            //}

            //else if (btnMostrarOcultar.Text == "Ocultar")
            //{
            //    dgvCliente.Rows.Clear();

            //    btnMostrarOcultar.Text = "Mostrar";

            //    btnGuardarEditar.Enabled = false;
            //    btnCancelar.Enabled = false;

            //    btnEditar.Enabled = false;
            //    btnBorrar.Enabled = false;

            //    btnRefrescar.Enabled = false;

            //    txtBuscar.Focus();
            //}

            //// Se reestablece el cursor por defecto
            //Cursor = Cursors.Default;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando";

            llenarControlesParaActualizar();

            gbLlenadoEdicion.Enabled = true;
            btnGuardarEditar.Enabled = true;
            txtNombres.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("¿Quieres borrar el cliente seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {                        
                    preEliminarCliente();

                    mostrarGridCliente();
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarGridCliente();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbLlenadoEdicion_Enter(object sender, EventArgs e)
        {

        }

        

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

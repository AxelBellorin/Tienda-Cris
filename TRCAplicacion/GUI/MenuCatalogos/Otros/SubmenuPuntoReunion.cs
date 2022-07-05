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
using TRCAplicacion.Controllers.PuntoReunion;

namespace TRCAplicacion.GUI.MenuCatalogos.Otros
{
    public partial class SubmenuPuntoReunion : Form
    {
        PaisC objPaisC = null;
        PaisController objPaisController = null;
        DataTable dtPais = null;

        DepartamentoC objDepartamentoC = null;
        DepartamentoController objDepartamentoController = null;
        DataTable dtDepartamento = null;

        MunicipioC objMunicipioC = null;
        MunicipioController objMunicipioController = null;
        DataTable dtMunicipio = null;

        PuntoReunionC objPuntoReunionC = null;
        PuntoReunionController objPuntoReunionController = null;
        DataTable dtPuntoReunion = null;

        public SubmenuPuntoReunion()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        #region Mostrar listas Pais, Departamento, Municipio, PuntoReunion

        

        private void mostrarListaDepartamento()
        {
            if (lbPais.SelectedItem != null)
            {
                lbDepartamento.Items.Clear();

                objDepartamentoC = new DepartamentoC();
                objDepartamentoController = new DepartamentoController(objDepartamentoC);

                dtDepartamento = new DataTable();

                dtDepartamento = objDepartamentoController.mostrarDepartamentos(lbPais.SelectedItem.ToString());

                if (dtDepartamento.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDepartamento.Rows.Count; i++)
                    {
                        lbDepartamento.Items.Add(dtDepartamento.Rows[i][0].ToString());
                    }
                }

                else
                {
                    MessageBox.Show("No se encontraron departamentos para el pais\n\"" + lbPais.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un pais", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gbDepartamento.Text = "Departamento (" + lbDepartamento.Items.Count.ToString() + ")";
        }

        private void mostrarListaMunicipio()
        {
            if (lbDepartamento.SelectedItem != null)
            {
                lbMunicipio.Items.Clear();

                objMunicipioC = new MunicipioC();
                objMunicipioController = new MunicipioController(objMunicipioC);

                dtMunicipio = new DataTable();
                dtMunicipio = objMunicipioController.mostrarMunicipios(lbDepartamento.SelectedItem.ToString(), lbPais.SelectedItem.ToString());

                if (dtMunicipio.Rows.Count > 0)
                {
                    for (int i = 0; i < dtMunicipio.Rows.Count; i++)
                    {
                        lbMunicipio.Items.Add(dtMunicipio.Rows[i][0].ToString());
                    }
                }

                else
                {
                    MessageBox.Show("No se encontraron municipios para el departamento\n\"" + lbDepartamento.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un departamento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gbMunicipio.Text = "Municipio (" + lbMunicipio.Items.Count.ToString() + ")";
        }

        private void mostrarListaPuntoReunion()
        {
            if (lbMunicipio.SelectedItem != null)
            {
                lbPuntoReunion.Items.Clear();

                objPuntoReunionC = new PuntoReunionC();
                objPuntoReunionController = new PuntoReunionController(objPuntoReunionC);

                dtPuntoReunion = new DataTable();

                dtPuntoReunion = objPuntoReunionController.mostrarPuntosReunion(lbMunicipio.SelectedItem.ToString(), lbDepartamento.SelectedItem.ToString(), lbPais.SelectedItem.ToString());

                if (dtPuntoReunion.Rows.Count > 0)
                {
                    for (int i = 0; i < dtPuntoReunion.Rows.Count; i++)
                    {
                        lbPuntoReunion.Items.Add(dtPuntoReunion.Rows[i][0].ToString());
                    }
                }

                else
                {
                    MessageBox.Show("No se encontraron puntos de reunion para el municipio\n\"" + lbMunicipio.SelectedItem.ToString() + "\"", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un municipio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gbPuntoReunion.Text = "Punto reunion (" + lbPuntoReunion.Items.Count.ToString() + ")";
        }

        #endregion

        #region Pais

        private void mostrarListaPais()
        {
            lbPais.Items.Clear();

            objPaisC = new PaisC();
            objPaisController = new PaisController(objPaisC);

            dtPais = new DataTable();
            dtPais = objPaisController.mostrarPaises();

            if (dtPais.Rows.Count > 0)
            {
                for (int i = 0; i < dtPais.Rows.Count; i++)
                {
                    lbPais.Items.Add(dtPais.Rows[i][0].ToString());
                }
            }

            gbPais.Text = "Pais (" + lbPais.Items.Count.ToString() + ")";
        }

        private void preInsertarPais()
        {
            try
            {
                // Se crea un objeto pais
                objPaisC = new PaisC();

                // Se le asignan los valores
                objPaisC.Pais = txtNombre.Text;

                objPaisController = new PaisController(objPaisC);

                objPaisController.insertarPais();

                MessageBox.Show("Pais \"" + txtNombre.Text + "\" guardado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido guardar el pais \"" + txtNombre.Text + "\".\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mostrarListaPais();
        }

        private void preEditarPais()
        {
            try
            {
                // Se crea un objeto pais
                objPaisC = new PaisC();

                // Se le asignan los valores
                objPaisC.Pais = txtNombre.Text;

                objPaisController = new PaisController(objPaisC);

                objPaisController.actualizarPais(lbPais.SelectedItem.ToString());

                MessageBox.Show("Pais \"" + txtNombre.Text + "\" editado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido editar el pais \"" + txtNombre.Text + "\".\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mostrarListaPais();
        }

        private void preBorrarPais()
        {
            try
            {
                // Se crea un objeto pais
                objPaisC = new PaisC();

                objPaisController = new PaisController(objPaisC);

                objPaisController.eliminarPais(lbPais.SelectedItem.ToString());

                MessageBox.Show("Pais \"" + txtNombre.Text + "\" borrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Excepcion)
            {
                MessageBox.Show("No se ha podido borrar el pais \"" + txtNombre.Text + "\".\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mostrarListaPais();
        }

        #endregion

        #region Departamento

        #endregion

        #region Municipio

        #endregion

        #region Punto reunion

        #endregion

        private void SubmenuPuntoReunion_Load(object sender, EventArgs e)
        {
            mostrarListaPais();
        }

        private void cntmOpcionesPuntoReunion_Opening(object sender, CancelEventArgs e)
        {
            if (lbPais.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo pais";
            }

            if (lbDepartamento.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo departamento";
            }

            if (lbMunicipio.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo municipio";
            }

            if (lbPuntoReunion.Focused)
            {
                nuevoToolStripMenuItem.Text = "Nuevo punto de reunion";
            }
        }

        private void lbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPais.SelectedIndex != -1)
            {
                btnEditarPais.Enabled = true;
                btnBorrarPais.Enabled = true;
            }

            else
            {
                btnEditarPais.Enabled = false;
                btnBorrarPais.Enabled = false;
            }

            mostrarListaDepartamento();
        }

        private void lbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarListaMunicipio();
        }

        private void lbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarListaPuntoReunion();
        }

        #region Eventos clic boton nuevo pais, departamento, municipio, punto reunion
        private void btnNuevoPais_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando pais";

            txtNombre.Text = String.Empty;
            txtNombre.Focus();
        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando departamento";

            txtNombre.Text = String.Empty;
            txtNombre.Focus();
        }

        private void btnNuevoMunicipio_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando municipio";

            txtNombre.Text = String.Empty;
            txtNombre.Focus();
        }

        private void btnNuevoPuntoReunion_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Ingresando punto de reunion";

            txtNombre.Text = String.Empty;
            txtNombre.Focus();
        }

        #endregion

        private void llenarControlesParaActualizar(ListBox lista)
        {
            txtNombre.Text = lista.SelectedItem.ToString();
        }

        #region Eventos clic boton editar pais, departamento, municipio, punto reunion

        private void btnEditarPais_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando pais";

            llenarControlesParaActualizar(lbPais);

            txtNombre.Focus();
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando departamento";

            llenarControlesParaActualizar(lbDepartamento);

            txtNombre.Focus();
        }

        private void btnEditarMunicipio_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando municipio";

            llenarControlesParaActualizar(lbMunicipio);

            txtNombre.Focus();
        }

        private void btnEditarPuntoReunion_Click(object sender, EventArgs e)
        {
            gbLlenadoEdicion.Text = "Editando punto de reunion";

            llenarControlesParaActualizar(lbPuntoReunion);

            txtNombre.Focus();
        }

        #endregion

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Si hay texto se habilita el boton en caso contrario se deshabilita
            if (txtNombre.Text != String.Empty)
            {
                btnGuardarEditar.Enabled = true;
            }

            else
            {
                btnGuardarEditar.Enabled = false;
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = String.Empty;
            txtNombre.Focus();
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (gbLlenadoEdicion.Text == "Ingresando pais")
            {
                preInsertarPais();
            }

            else if (gbLlenadoEdicion.Text == "Editando pais")
            {
                preEditarPais();
            }





            else if (gbLlenadoEdicion.Text == "Ingresando departamento")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el departamento.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (gbLlenadoEdicion.Text == "Editando departamento")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido editar el departamento.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





            else if (gbLlenadoEdicion.Text == "Ingresando municipio")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el municipio.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (gbLlenadoEdicion.Text == "Editando municipio")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido editar el municipio.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            else if (gbLlenadoEdicion.Text == "Ingresando punto de reunion")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido guardar el punto de reunion.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (gbLlenadoEdicion.Text == "Editando punto de reunion")
            {
                try
                {

                }
                catch (Exception Excepcion)
                {
                    MessageBox.Show("No se ha podido editar el punto de reunion.\nHemos encontrado el siguinte error: " + Excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





            else
            {
                MessageBox.Show("No has seleccionado ninguna accion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Limpiar();
        }

    #region Eventos clic boton borrar pais, departamento, municipio, punto reunion

        private void btnBorrarPais_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarMunicipio_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarPuntoReunion_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void lbPuntoReunion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

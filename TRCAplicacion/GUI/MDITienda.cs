using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TRCAplicacion.GUI.MenuCatalogos;
using TRCAplicacion.GUI.MenuCatalogos.Otros;
using TRCAplicacion.GUI.MenuOperaciones;

using TRCAplicacion.GUI.MenuOperaciones.Otros;
using TRCAplicacion.Controllers.Login;
using TRCAplicacion.GUI.MenuReportes;

using TRCAplicacion.Models;

namespace TRCAplicacion.GUI
{
    public partial class MDITienda : Form
    {
        public static bool sesionIniciada = false;
        private Form formActivo = null;

        public MDITienda()
        {
            InitializeComponent();
        }

        private void cargarFormulario(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();

            formActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;

            formHijo.Show();
        }

        private void InicializarMenu()
        {
            panel1.Visible = false;

            pnlSubmenuCatalogos.Visible = false;
            pnlSubmenuOperaciones.Visible = false;
            pnlSubmenuReportes.Visible = false;
        }

        private void OcultarSubmenus()
        {
            if (pnlSubmenuCatalogos.Visible == true)
                pnlSubmenuCatalogos.Visible = false;
            if (pnlSubmenuOperaciones.Visible == true)
                pnlSubmenuOperaciones.Visible = false;
            if (pnlSubmenuReportes.Visible == true)
                pnlSubmenuReportes.Visible = false;
        }

        private void MDITienda_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            InicializarMenu();
        }

        private void MDITienda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("ddd") + " " + DateTime.Now.ToString("dd") + " " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.ToString("yy");
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            pnlSubmenuCatalogos.Visible = true;
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            pnlSubmenuOperaciones.Visible = true;

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            pnlSubmenuReportes.Visible = true;
        }

        private void lblOpcionesUsuario_Click(object sender, EventArgs e)
        {
            if (sesionIniciada == false)
            {
                Login login = new Login();
                login.ShowDialog();

                if (sesionIniciada == true)
                {
                    panel1.Visible = true;

                    lblUsuario.Text = LoginC.Usuario;
                    lblOpcionesUsuario.Text = "Opciones";
                }
            }

            else
            {
                // cntmOpcionesUsuario.Show();
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            SubmenuProducto producto = new SubmenuProducto();
            cargarFormulario(producto);

            OcultarSubmenus();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SubmenuCliente cliente = new SubmenuCliente();
            cargarFormulario(cliente);

            OcultarSubmenus();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            SubmenuProveedor proveedor = new SubmenuProveedor();
            cargarFormulario(proveedor);

            OcultarSubmenus();
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            SubmenuTrabajador trabajador = new SubmenuTrabajador();
            cargarFormulario(trabajador);

            OcultarSubmenus();
        }

        // Eventos MouseHover y MouseLeave
        private void btnCatalogos_MouseHover(object sender, EventArgs e)
        {
            //btnCatalogos.BackColor = Color.White;
            btnCatalogos.ForeColor = Color.FromArgb(6, 188, 193);

            pnlIMenuCatalogos.Location = btnCatalogos.Location;
            pnlIMenuCatalogos.Visible = true;
        }

        private void btnCatalogos_MouseLeave(object sender, EventArgs e)
        {
            //btnCatalogos.BackColor = Color.Transparent;
            btnCatalogos.ForeColor = Color.White;

            pnlIMenuCatalogos.Visible = false;            
        }

        private void btnProducto_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Location = btnProducto.Location;
            pnlISubmenuCatalogos.Visible = true;
        }

        private void btnProducto_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Visible = false;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Location = btnCliente.Location;
            pnlISubmenuCatalogos.Visible = true;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Visible = false;
        }

        private void btnProveedor_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Location = btnProveedor.Location;
            pnlISubmenuCatalogos.Visible = true;
        }

        private void btnProveedor_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Visible = false;
        }

        private void btnTrabajador_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Location = btnTrabajador.Location;
            pnlISubmenuCatalogos.Visible = true;
        }

        private void btnTrabajador_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuCatalogos.Visible = false;
        }

        private void tallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuTalla talla = new SubmenuTalla();
            cargarFormulario(talla);

            OcultarSubmenus();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuMarca marca = new SubmenuMarca();
            cargarFormulario(marca);

            OcultarSubmenus();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuCargo cargo = new SubmenuCargo();
            cargarFormulario(cargo);

            OcultarSubmenus();
        }

        private void imaConfiguracion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuracion");
        }

        private void imaSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SubmenuPedidoCliente pedidoCliente = new SubmenuPedidoCliente();
            cargarFormulario(pedidoCliente);

            OcultarSubmenus();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cntmOpcionesUsuario_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cntmTrabajador_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSubmenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlIMenuOperaciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOperaciones_MouseHover(object sender, EventArgs e)
        {
            pnlIMenuOperaciones.Location = btnOperaciones.Location;
            pnlIMenuOperaciones.Visible = true;

            btnOperaciones.ForeColor = Color.FromArgb(6, 188, 193);
        }

        private void btnOperaciones_MouseLeave(object sender, EventArgs e)
        {
            pnlIMenuOperaciones.Visible = false;

            btnOperaciones.ForeColor = Color.White;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Location = button6.Location;
            pnlISubmenuOperaciones.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Location = button5.Location;
            pnlISubmenuOperaciones.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Location = button4.Location;
            pnlISubmenuOperaciones.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuOperaciones.Visible = false;
        }

        private void btnReportes_MouseHover(object sender, EventArgs e)
        {
            pnlIMenuReportes.Location = btnReportes.Location;
            pnlIMenuReportes.Visible = true;

            btnReportes.ForeColor = Color.FromArgb(6, 188, 193);
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            pnlIMenuReportes.Visible = false;

            btnReportes.ForeColor = Color.White;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            pnlISubmenuReportes.Visible = true;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            pnlISubmenuReportes.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubmenuEncargoCliente encargoCliente = new SubmenuEncargoCliente();
            cargarFormulario(encargoCliente);

            OcultarSubmenus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imaNotificacion_Click(object sender, EventArgs e)
        {

        }

        private void imaMenu_Click(object sender, EventArgs e)
        {

        }

        private void imaInicio_Click(object sender, EventArgs e)
        {

        }

        private void cntmProducto_Opening(object sender, CancelEventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuCategoria categoria = new SubmenuCategoria();
            cargarFormulario(categoria);

            OcultarSubmenus();
        }

        private void estadoEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuEstadoEncargo estadoEncargo = new SubmenuEstadoEncargo();
            cargarFormulario(estadoEncargo);

            OcultarSubmenus();
        }

        private void tipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuTipoPago tipoPago = new SubmenuTipoPago();
            cargarFormulario(tipoPago);

            OcultarSubmenus();
        }

        private void tipoDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubmenuTipoPago tipoPago = new SubmenuTipoPago();
            cargarFormulario(tipoPago);

            OcultarSubmenus();
        }

        private void MDITienda_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void puntoDeReunionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmenuPuntoReunion puntoReunion = new SubmenuPuntoReunion();
            cargarFormulario(puntoReunion);

            OcultarSubmenus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmenuCompraProveedor compraProveedor = new SubmenuCompraProveedor();
            cargarFormulario(compraProveedor);

            OcultarSubmenus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            cargarFormulario(reportes);
            OcultarSubmenus();
        }
    }
}

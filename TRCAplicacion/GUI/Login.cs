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
using TRCAplicacion.Controllers.Login;

namespace TRCAplicacion.GUI
{
    public partial class Login : Form
    {
        LoginC objLoginC = null;
        LoginController objLoginController = null;
        DataTable dt = null;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void preVerificarAcceso()
        {
            objLoginC = new LoginC();

            // Se le asignan los valores
            LoginC.Usuario = txtUsuario.Text;
            LoginC.Contrasena = txtContraseña.Text;

            //Conexion2.Usuario = txtUsuario.Text;
            //Conexion2.Contrasena = txtContraseña.Text;

            objLoginController = new LoginController(objLoginC);

            if (objLoginController.verificarAcceso() == true)
            {
                MDITienda.sesionIniciada = true;
                MessageBox.Show("¡Bienvenido " + txtUsuario.Text + "!", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                MessageBox.Show("Error, intente otra vez", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = String.Empty;
                txtContraseña.Text = String.Empty;
                txtUsuario.Focus();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != String.Empty && txtContraseña.Text != String.Empty)
            {
                // Verificar datos
                preVerificarAcceso();
            }

            else
            {
                MessageBox.Show("Por favor, llene ambos campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrar.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }

            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}

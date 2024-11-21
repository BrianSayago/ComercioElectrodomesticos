using Datos;
using Microsoft.Data.SqlClient;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
            txtUsername.KeyDown += new KeyEventHandler(txtUsername_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                int? usuarioId = SuperCapa.ValidarUsuario(txtUsername.Text, txtPassword.Text);

                if (usuarioId.HasValue)
                {
                    AuthManager.Instance.SetUsuarioId(usuarioId.Value);
                    this.Hide();
                    BienvenidaForm bienvenidaFrm = new BienvenidaForm();
                    bienvenidaFrm.ShowDialog();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }

        }

        private void chkboxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPw.Checked)
            { txtPassword.UseSystemPasswordChar = false; }
            else
            { txtPassword.UseSystemPasswordChar = true; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIniciarSesion.PerformClick();
            }
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {

            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIniciarSesion.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIniciarSesion.PerformClick();
            }
        }

        private void linkPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraFrm recuperarContraFrm = new RecuperarContraFrm();
            recuperarContraFrm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.91;
        }
    }
}
    

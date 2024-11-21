using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class RecuperarContraFrm : Form
    {
        private int usuarioId;
        public RecuperarContraFrm()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }


        private void btnObtenerContrasena_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtUsuarioID.Text) || !int.TryParse(txtUsuarioID.Text, out int usuarioID))
                {
                    MessageBox.Show("Por favor, ingresa un UsuarioID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string email = SuperCapa.ObtenerEmailPorUsuarioID(usuarioID);
                if (email != null)
                {
                    txtEmail.Text = email;
                }

                string contrasena = SuperCapa.ObtenerContrasenaPorCorreo(email);

                if (contrasena != null)
                {
                    txtContrasena.Text = contrasena;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
           
        }
    }
}

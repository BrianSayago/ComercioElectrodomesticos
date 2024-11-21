using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using static Negocio.UsuarioService;

namespace Presentacion
{
    public partial class BienvenidaForm : Form
    {
        private int usuarioId;
        private Usuario _usuario;
       

        public BienvenidaForm()
        {
            
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
        private void BienvenidaForm_Load(object sender, EventArgs e)
        {
            UsuarioService usuarioService = new UsuarioService();
            UsuarioService.Usuario usuario = usuarioService.ObtenerUsuarioPorID(usuarioId);

            if (usuario != null)
            {

                lblUsername.Text = $"{usuario.Nombre}, {usuario.Apellido}";
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                lblUsername.Text = "Usuario desconocido";
            }
            this.Opacity = 0.0;

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            timer1.Start();
        }

       
    }
}


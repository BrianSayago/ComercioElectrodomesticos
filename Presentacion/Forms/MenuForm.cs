using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            timerClock.Start();
            timerFecha.Start();
        }

        private bool isCollapsed;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wParam, int lParam);
        private void AbrirFormInPanel(object Formhijo)
        {
            lblClock.Visible = false;
            lblDate.Visible = false;
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;

            fh.FormClosed += (s, e) =>
            {
                lblClock.Visible = true;
                lblDate.Visible = true;
            };

            fh.Show();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Ventas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Proveedores());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Compras());
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            timerSlide.Interval = 5;
            timerSlide.Start();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Historial());
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Documentos());
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
                iconRestore.Visible = true;
                iconMax.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestore.Visible = false;
            iconMax.Visible = true;
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                MenuVertical.Width -= 20;
                if (MenuVertical.Width <= 70)
                {
                    timerSlide.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                MenuVertical.Width += 20;
                if (MenuVertical.Width >= 250)
                {
                    timerSlide.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy.");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}

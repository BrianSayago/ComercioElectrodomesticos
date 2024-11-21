using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class Documentos : Form
    {
        public Documentos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbDocumentos_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = @"C:\Remitos";

            if (Directory.Exists(rutaDirectorio))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaDirectorio,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("El directorio \"C:\\Remitos\" no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

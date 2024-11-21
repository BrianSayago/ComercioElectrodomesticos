using Presentacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistoricoVC_Click(object sender, EventArgs e)
        {
            HistoricoVCFrm historicoVCFrm = new HistoricoVCFrm();
            historicoVCFrm.ShowDialog();
        }

        private void btnRegistroCambios_Click(object sender, EventArgs e)
        {
            RegistroMovimientosFrm registroMovimientosFrm = new RegistroMovimientosFrm();
            registroMovimientosFrm.ShowDialog();
        }
    }
}

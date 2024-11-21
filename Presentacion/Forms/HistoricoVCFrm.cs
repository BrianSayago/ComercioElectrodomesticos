using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class HistoricoVCFrm : Form
    {

        public HistoricoVCFrm()
        {
            InitializeComponent();
        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HistoricoVCFrm_Load(object sender, EventArgs e)
        {
            CargarData();
        }
        private void CargarData()
        {
            try
            {

                DataTable result = SuperCapa.CargarTablaHV();
                dgvHistoricoVC.DataSource = result;
            }
            catch (Exception ex)
            {
                MostrarError("cargar el historico de ventas y compras en", ex);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable ventasFiltradas = HistorialService.FiltrarVCPorFecha(fechaInicio, fechaFin);

            dgvHistoricoVC.DataSource = ventasFiltradas;
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            DataTable todasLasVentasCompras = HistorialService.ObtenerTodasLasVentasCompras();
            dgvHistoricoVC.DataSource = todasLasVentasCompras;
        }
        private void Actualizar()
        {
            HistoricoVCFrm_Load(null, null);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}

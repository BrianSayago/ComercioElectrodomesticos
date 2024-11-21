using Datos;
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
    public partial class RegistroMovimientosFrm : Form
    {
        public RegistroMovimientosFrm()
        {
            InitializeComponent();

        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroMovimientosFrm_Load(object sender, EventArgs e)
        {
            CargarData();
        }
        private void CargarData()
        {
            try
            {
                DataTable result = SuperCapa.CargarTablaRM();
                dgvMovimientos.DataSource = result;
            }
            catch (Exception ex)
            {
                MostrarError("cargar ultimos movimientos en", ex);
            }
        }

        private void Actualizar()
        {
            RegistroMovimientosFrm_Load(null, null);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
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

            
            DataTable movimientosFiltrados = HistorialService.FiltrarMovimientosPorFecha(fechaInicio, fechaFin);

            dgvMovimientos.DataSource = movimientosFiltrados;

        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            DataTable todosLosMovimientos = HistorialService.ObtenerTodosLosMovimientos();
            dgvMovimientos.DataSource = todosLosMovimientos;

        }
    }
}

using Datos;
using Microsoft.Data.SqlClient;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.VentaService;

namespace Presentacion.Forms
{
    public partial class ModificarVentaFrm : Form
    {
        ConexionConBD dbConnection;
        private Ventas ventasForm;
        private Venta _venta;
        VentaService ventaService;
        public ModificarVentaFrm(Ventas ventasForm)
        {
            InitializeComponent();
            this.ventasForm = ventasForm;
            LoadClientes();
        }
        private void LoadClientes()
        {

            string query = "SELECT ClienteID, Nombre FROM Clientes";
            DataTable dt = ConexionConBD.ExecuteQuery(query);

            cmbClientes.DataSource = dt;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "ClienteID";
        }

        public void SetVenta(Venta venta)
        {
            _venta = venta;
            txtVentaID.Text = _venta.VentaID.ToString();
            cmbClientes.SelectedValue = _venta.ClienteID;
            dtpFecha.Value = _venta.FechaVenta;
            txtTotal.Text = _venta.Total.ToString();
        }
        private bool ConfirmarModificacion()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar esta venta?",
                                                     "Confirmación de modificación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
            return resultado == DialogResult.Yes;
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtVentaID.Text) || cmbClientes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarFormatoDecimal()
        {
            decimal total;
            if (!decimal.TryParse(txtTotal.Text, out total))
            {
                MessageBox.Show("El formato del total no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                _venta.VentaID = Convert.ToInt32(txtVentaID.Text);
                _venta.ClienteID = Convert.ToInt32(cmbClientes.SelectedValue);
                _venta.FechaVenta = dtpFecha.Value;
                _venta.Total = Convert.ToDecimal(txtTotal.Text);

                if (!ValidarCamposObligatorios()) return;
                if (!ValidarFormatoDecimal()) return;
                if (ConfirmarModificacion())
                {

                    try
                    {

                        VentaService.ModificarVenta(_venta);
                        SuperCapa.RegistrarHistorialModificacionesVenta(_venta.VentaID);
                        MessageBox.Show("Venta actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La modificación ha sido cancelada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

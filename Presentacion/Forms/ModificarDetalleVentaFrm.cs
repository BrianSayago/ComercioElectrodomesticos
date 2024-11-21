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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.VentaService;

namespace Presentacion.Forms
{
    public partial class ModificarDetalleVentaFrm : Form
    {
        private DetalleVenta _detalleVenta;
        private Ventas ventasForm;

        
        public ModificarDetalleVentaFrm(Ventas ventasForm)
        {
            InitializeComponent();
            LoadProductos();
            this.ventasForm = ventasForm;
        }

        public void SetDetalleVenta(DetalleVenta detalleVenta)
        {
            _detalleVenta = detalleVenta;
            txtDetalleVenta.Text = _detalleVenta.DetalleVentaID.ToString();
            cmbProductos.SelectedValue = _detalleVenta.ProductoID;
            txtCantidadVenta.Text = _detalleVenta.Cantidad.ToString();
            txtPrecioUnitario.Text = _detalleVenta.PrecioUnitario.ToString();
            txtSubtotal.Text = _detalleVenta.Subtotal.ToString();
        }

        private void LoadProductos()
        {

            DataTable dt1 = SuperCapa.CargarProductos();

            cmbProductos.DataSource = dt1;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "ProductoID";
        }

        private bool ConfirmarModificacion()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar este detalle de la venta?",
                                                  "Confirmar Modificación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private bool ValidarCamposObligatorios()
        {
            if (cmbProductos.SelectedValue == null || Convert.ToInt32(cmbProductos.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadVenta.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                MessageBox.Show("Debe ingresar el precio unitario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarFormatoDecimal()
        {
            if (!decimal.TryParse(txtPrecioUnitario.Text, out _))
            {
                MessageBox.Show("El precio unitario debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCantidadVenta.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardarDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {


                _detalleVenta.DetalleVentaID = Convert.ToInt32(txtDetalleVenta.Text);
                _detalleVenta.ProductoID = Convert.ToInt32(cmbProductos.SelectedValue);
                _detalleVenta.Cantidad = Convert.ToInt32(txtCantidadVenta.Text);
                _detalleVenta.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                _detalleVenta.Subtotal = _detalleVenta.Cantidad * _detalleVenta.PrecioUnitario;

                if (!ValidarCamposObligatorios()) return;
                if (!ValidarFormatoDecimal()) return;
                if (ConfirmarModificacion())
                {

                    try
                    {

                        VentaService.ModificarDetalleVenta(_detalleVenta);
                        SuperCapa.RegistrarHistorialModificaciones(_detalleVenta.DetalleVentaID);
                        MessageBox.Show("Detalle de venta actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el detalle de venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBox.Show("La modificación ha sido cancelada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el detalle venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }



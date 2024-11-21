using Datos;
using Microsoft.Data.SqlClient;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.CompraService;



namespace Presentacion.Forms
{
    public partial class ModificarDetalleCompra : Form
    {
        private DetalleCompra _detalleCompra;
        ConexionConBD dbConnection;
        private Compras comprasForm;
        CompraService compraService;
        public ModificarDetalleCompra(Compras comprasForm)
        {
            InitializeComponent();
            LoadProductos();
            this.comprasForm = comprasForm;
        }
        private void LoadProductos()
        {

            DataTable dt1 = SuperCapa.CargarProductos();

            cmbProductos.DataSource = dt1;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "ProductoID";
        }
        public void SetDetalleCompra(DetalleCompra detalleCompra)
        {
            _detalleCompra = detalleCompra;
            txtDetalleCompra.Text = _detalleCompra.DetalleCompraID.ToString();
            cmbProductos.SelectedValue = _detalleCompra.ProductoID;
            txtCantidadCompra.Text = _detalleCompra.Cantidad.ToString();
            txtPrecioUnitario.Text = _detalleCompra.PrecioUnitario.ToString();
            txtSubtotal.Text = _detalleCompra.Subtotal.ToString();
        }

        private void btnGuardarDetalleCompra_Click(object sender, EventArgs e)
        {
            try
            {
                _detalleCompra.DetalleCompraID = Convert.ToInt32(txtDetalleCompra.Text);
                _detalleCompra.ProductoID = Convert.ToInt32(cmbProductos.SelectedValue);
                _detalleCompra.Cantidad = Convert.ToInt32(txtCantidadCompra.Text);
                _detalleCompra.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                _detalleCompra.Subtotal = _detalleCompra.Cantidad * _detalleCompra.PrecioUnitario;

                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtCantidadCompra.Text))
                {
                    MessageBox.Show("Ingrese una cantidad valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtPrecioUnitario.Text))
                {
                    MessageBox.Show("Ingrese un precio unitario valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtSubtotal.Text))
                {
                    MessageBox.Show("Ingrese un subtotal valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {

                    CompraService.ModificarDetalleCompra(_detalleCompra);
                    SuperCapa.RegistrarHistorialModificacionesCompra(_detalleCompra.DetalleCompraID);
                    MessageBox.Show("Detalle de compra actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el detalle de compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el detalle compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


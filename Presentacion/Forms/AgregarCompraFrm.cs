using Datos;
using Microsoft.Data.SqlClient;
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
using static Presentacion.ValidacionesCapaPresentacion;

namespace Presentacion.Forms
{
    public partial class AgregarCompraFrm : Form
    {

        private int usuarioId;

        public AgregarCompraFrm()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }
        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private decimal ConvertirDecimal(string input)
        {
            try
            {
                var culture = new System.Globalization.CultureInfo("es-AR");
                return decimal.Parse(input, System.Globalization.NumberStyles.Currency, culture);
            }
            catch (FormatException ex)
            {
                MostrarError("convertir el valor a decimal", ex);
                return 0;
            }
        }


        private void ConfigurarDgvCarrito()
        {
            dgvCarrito.Columns.Add("ProductoID", "ProductoID");
            dgvCarrito.Columns.Add("Nombre", "Nombre");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");
        }


        private void LoadProveedores()
        {

            DataTable result = SuperCapa.CargarProveedores();


            cmbProveedores.DataSource = result;
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "ProveedorID";
        }
        private void LoadProducts()
        {
            DataTable dtProductos = SuperCapa.CargarTablaProductos();
            dgvProductos.DataSource = dtProductos;
        }

        private void AgregarCompraFrm_Load(object sender, EventArgs e)
        {
            LoadProveedores();
            ConfigurarDgvCarrito();
            LoadProducts();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    string subtotalStr = row.Cells["subtotal"].Value.ToString();
                    decimal subtotal = 0;

                    if (decimal.TryParse(subtotalStr, System.Globalization.NumberStyles.Currency, new System.Globalization.CultureInfo("es-AR"), out subtotal))
                    {
                        total += subtotal;
                    }
                    else
                    {
                        MostrarError("convertir el subtotal a decimal", new Exception("El formato del subtotal no es válido."));
                    }
                }
            }
            txtTotal.Text = total.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }




        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                {
                    int productoId = Convert.ToInt32(row.Cells["ProductoID"].Value);
                    string nombre = row.Cells["Nombre"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    int cantidad = 1;

                    dgvCarrito.Rows.Add(productoId, nombre, cantidad, precio, cantidad * precio);
                }
                UpdateTotal();
            }
        }
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int proveedorId = Convert.ToInt32(cmbProveedores.SelectedValue);
                DateTime fechaCompra = DateTime.Now;
                decimal total = ConvertirDecimal(txtTotal.Text);

                int compraId = SuperCapa.InsertarCompra(proveedorId, fechaCompra, total, usuarioId);
                CompraService.RegistrarRegistroCambioCompra(compraId, "Compras", "INSERT", proveedorId, total, fechaCompra);
                CompraService.RegistrarHistorialCompra(compraId, proveedorId, total, fechaCompra);

                foreach (DataGridViewRow row in dgvCarrito.Rows)
                {
                    if (row.Cells["ProductoID"].Value != null)
                    {
                        int productoId = (int)row.Cells["ProductoID"].Value;
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precioUnitario = ConvertirDecimal(row.Cells["PrecioUnitario"].Value.ToString());
                        decimal subtotal = cantidad * precioUnitario;

                        SuperCapa.InsertarDetalleCompra(compraId, productoId, cantidad, precioUnitario, subtotal);
                    }
                }
                MessageBox.Show("Compra guardada con éxito.");
                FormularioUtilidades.LimpiarCampos(this);
                dgvCarrito.Columns.Clear();
                ConfigurarDgvCarrito();
                LoadProducts();

            }
            catch (Exception ex)
            {
                MostrarError("guardar la compra", ex);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using static Presentacion.ValidacionesCapaPresentacion;


namespace Presentacion.Forms
{
    public partial class AgregarVentaFrm : Form
    {
        private int usuarioId;

        public AgregarVentaFrm()
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

        private void LoadProducts()
        {
            try
            {
                DataTable dataTable = SuperCapa.CargarProductos();
                dgvProductos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MostrarError("cargar los productos en", ex);
            }
        }

        private void LoadClientes()
        {
            try
            {
                DataTable dt = SuperCapa.CargarClientes();
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.");
                    return;
                }
                if (!dt.Columns.Contains("Nombre") || !dt.Columns.Contains("ClienteID"))
                {
                    MessageBox.Show("Las columnas requeridas no están presentes en el DataTable.");
                    return;
                }
                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "ClienteID";
            }
            catch (Exception ex)
            {
                MostrarError("cargar los clientes en", ex);
            }
        }

        private void AgregarVentaFrm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            ConfigurarDgvCarrito();
            LoadClientes();
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
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);
                DateTime fechaVenta = DateTime.Now;
                decimal total = ConvertirDecimal(txtTotal.Text);

                int ventaId = SuperCapa.InsertarVenta(clienteId, fechaVenta, total, usuarioId);


                foreach (DataGridViewRow row in dgvCarrito.Rows)
                {
                    if (row.Cells["ProductoID"].Value != null)
                    {
                        int productoId = (int)row.Cells["ProductoID"].Value;
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precioUnitario = ConvertirDecimal(row.Cells["PrecioUnitario"].Value.ToString());
                        decimal subtotal = cantidad * precioUnitario;

                        SuperCapa.InsertarDetalleVenta(ventaId, productoId, cantidad, precioUnitario, subtotal);

                    }
                }

                SuperCapa.RegistrarHistorialVenta(ventaId, clienteId, total, fechaVenta);
                SuperCapa.RegistrarRegistroCambio(usuarioId, "Ventas", "INSERT", ventaId, clienteId, total, fechaVenta);

                List<DetalleVenta> detalles = VentaService.ObtenerDetalleVenta(ventaId);
                string nombreCliente = cmbClientes.Text;
                VentaService.GenerarRemitoPDF(ventaId, nombreCliente, total, fechaVenta, detalles);
                MessageBox.Show("Venta realizada con éxito y remito generado correctamente..");
                FormularioUtilidades.LimpiarCampos(this);
                dgvCarrito.Columns.Clear();
                ConfigurarDgvCarrito();
                LoadProducts();

            }
            catch (Exception ex)
            {
                MostrarError("guardar la venta", ex);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

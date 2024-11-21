using Datos;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Negocio;
using Presentacion.Forms;
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

namespace Presentacion
{
    public partial class Ventas : Form
    {
        private ModificarVentaFrm modificarVentaFrm;
        private ModificarDetalleVentaFrm modificarDetalleVentaFrm;
        private int usuarioId;
        public Ventas()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarData();
            CargarData1();
        }
        private void CargarData()
        {
            try
            {
                DataTable result = SuperCapa.CargarTablaVentas();
                dgvVentas.DataSource = result;
            }
            catch (Exception ex)
            {
                MostrarError("cargar las ventas en", ex);
            }
        }

        private void CargarData1()
        {
            try
            {
                DataTable dt1 = SuperCapa.CargarTablaDetalleVentas();
                dgvVentasDetalladas.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MostrarError("cargar las ventas detalladas en", ex);
            }
        }

        private void Actualizar()
        {
            Ventas_Load(null, null);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {

            AgregarVentaFrm agregarVentaFrm = new AgregarVentaFrm();
            agregarVentaFrm.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && modificarVentaFrm != null && !modificarVentaFrm.IsDisposed)
                {
                    DataGridViewRow row = dgvVentas.Rows[e.RowIndex];

                    if (row.Cells["VentaID"].Value != null &&
                       row.Cells["ClienteID"].Value != null &&
                       row.Cells["FechaVenta"].Value != null &&
                       row.Cells["Total"].Value != null)

                    {
                        try
                        {
                            Venta venta = new Venta
                            {
                                VentaID = Convert.ToInt32(row.Cells["VentaID"].Value),
                                ClienteID = Convert.ToInt32(row.Cells["ClienteID"].Value),
                                FechaVenta = Convert.ToDateTime(row.Cells["FechaVenta"].Value),
                                Total = Convert.ToDecimal(row.Cells["Total"].Value),

                            };
                            modificarVentaFrm.SetVenta(venta);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener los datos de la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (modificarVentaFrm == null || modificarVentaFrm.IsDisposed)
            {
                modificarVentaFrm = new ModificarVentaFrm(this);
                modificarVentaFrm.Show();
            }
            else
            {
                modificarVentaFrm.BringToFront();
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            txtEliminarVenta.Visible = true;
            lblEliminarVenta.Visible = true;
 
            if (int.TryParse(txtEliminarVenta.Text, out int VentaID))
            {
                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtEliminarVenta))
                {
                    MessageBox.Show("Ingrese un número de VentaID valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
      
                    VentaService.EliminarVenta(VentaID,usuarioId);
                    MessageBox.Show("Venta eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtEliminarVenta.Visible = false;
                    lblEliminarVenta.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvVentasDetalladas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && modificarDetalleVentaFrm != null && !modificarDetalleVentaFrm.IsDisposed)
                {
                    DataGridViewRow row = dgvVentasDetalladas.Rows[e.RowIndex];

                    if (row.Cells["DetalleVentaID"].Value != null &&
                       row.Cells["VentaID"].Value != null &&
                       row.Cells["ProductoID"].Value != null &&
                       row.Cells["Cantidad"].Value != null &&
                       row.Cells["PrecioUnitario"].Value != null &&
                       row.Cells["Subtotal"].Value != null)

                    {
                        try
                        {
                            DetalleVenta detalleVenta = new DetalleVenta
                            {
                                DetalleVentaID = Convert.ToInt32(row.Cells["DetalleVentaID"].Value),
                                VentaID = Convert.ToInt32(row.Cells["VentaID"].Value),
                                ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                                Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                                PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                                Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)

                            };
                            modificarDetalleVentaFrm.SetDetalleVenta(detalleVenta);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener los datos de la venta detallada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnModificarDetalleVenta_Click(object sender, EventArgs e)
        {
            if (modificarDetalleVentaFrm == null || modificarDetalleVentaFrm.IsDisposed)
            {
                modificarDetalleVentaFrm = new ModificarDetalleVentaFrm(this);
                modificarDetalleVentaFrm.Show();
            }
            else
            {
                modificarDetalleVentaFrm.BringToFront();
            }

        }

        private void btnEliminarDetalleVenta_Click(object sender, EventArgs e)
        {
            txtDetalleVenta.Visible = true;
            lblDetalleVenta.Visible = true;

            
            if (int.TryParse(txtDetalleVenta.Text, out int DetalleVentaID))
            {
                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtDetalleVenta))
                {
                    MessageBox.Show("Ingrese un DetalleVentaID valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    
                    VentaService.EliminarDetalleVenta(DetalleVentaID,usuarioId);
                    MessageBox.Show("Venta detallada eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtDetalleVenta.Visible = false;
                    lblDetalleVenta.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la venta detallada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
    


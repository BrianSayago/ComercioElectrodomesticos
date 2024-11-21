using Datos;
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
using static Negocio.CompraService;
using static Presentacion.ValidacionesCapaPresentacion;


namespace Presentacion
{
    public partial class Compras : Form
    {
        private ModificarCompraFrm modificarCompraFrm;
        private ModificarDetalleCompra modificarDetalleCompraFrm;
        private Compra compra;
        private int usuarioId;

        public Compras()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Actualizar()
        {
            Compras_Load(null, null);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            CargarData();
            CargarData1();
        }
        private void CargarData()
        {
            try
            {

                DataTable result = SuperCapa.CargarTablaCompras();
                dgvCompras.DataSource = result;

            }
            catch (Exception ex)
            {
                MostrarError("cargar las compras en", ex);
            }
        }

        private void CargarData1()
        {
            try
            {

                DataTable dt1 = SuperCapa.CargarTablaDetalleCompras();
                dgvComprasDetalladas.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MostrarError("cargar las compras detalladas en", ex);
            }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            AgregarCompraFrm agregarCompraFrm = new AgregarCompraFrm();
            agregarCompraFrm.ShowDialog();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && modificarCompraFrm != null && !modificarCompraFrm.IsDisposed)
                {
                    DataGridViewRow row = dgvCompras.Rows[e.RowIndex];

                    if (row.Cells["CompraID"].Value != null &&
                       row.Cells["ProveedorID"].Value != null &&
                       row.Cells["FechaCompra"].Value != null &&
                       row.Cells["Total"].Value != null)

                    {
                        try
                        {
                            Compra compra = new Compra
                            {
                                CompraID = Convert.ToInt32(row.Cells["CompraID"].Value),
                                ProveedorID = Convert.ToInt32(row.Cells["ProveedorID"].Value),
                                FechaCompra = Convert.ToDateTime(row.Cells["FechaCompra"].Value),
                                Total = Convert.ToDecimal(row.Cells["Total"].Value),

                            };
                            modificarCompraFrm.SetCompra(compra);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener los datos de la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnModificarCompra_Click(object sender, EventArgs e)
        {
            if (modificarCompraFrm == null || modificarCompraFrm.IsDisposed)
            {
                modificarCompraFrm = new ModificarCompraFrm(this);
                modificarCompraFrm.Show();
            }
            else
            {
                modificarCompraFrm.BringToFront();
            }
        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                txtEliminarCompra.Visible = true;
                lblEliminarCompra.Visible = true;

                if (int.TryParse(txtEliminarCompra.Text, out int CompraID))
                {
                    if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtEliminarCompra))
                    {
                        MessageBox.Show("Ingrese un número de cliente valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CompraService.EliminarCompra(CompraID, usuarioId);
                    MessageBox.Show("Compra eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtEliminarCompra.Visible = false;
                    lblEliminarCompra.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvComprasDetalladas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && modificarDetalleCompraFrm != null && !modificarDetalleCompraFrm.IsDisposed)
                {
                    DataGridViewRow row = dgvComprasDetalladas.Rows[e.RowIndex];

                    if (row.Cells["DetalleCompraID"].Value != null &&
                       row.Cells["CompraID"].Value != null &&
                       row.Cells["ProductoID"].Value != null &&
                       row.Cells["Cantidad"].Value != null &&
                       row.Cells["PrecioUnitario"].Value != null &&
                       row.Cells["Subtotal"].Value != null)

                    {
                        try
                        {
                            DetalleCompra detalleCompra = new DetalleCompra
                            {
                                DetalleCompraID = Convert.ToInt32(row.Cells["DetalleCompraID"].Value),
                                CompraID = Convert.ToInt32(row.Cells["CompraID"].Value),
                                ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                                Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                                PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                                Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)

                            };
                            modificarDetalleCompraFrm.SetDetalleCompra(detalleCompra);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener los datos de la compra detallada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnModificarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (modificarDetalleCompraFrm == null || modificarDetalleCompraFrm.IsDisposed)
            {
                modificarDetalleCompraFrm = new ModificarDetalleCompra(this);
                modificarDetalleCompraFrm.Show();
            }
            else
            {
                modificarDetalleCompraFrm.BringToFront();
            }
        }

        private void btnEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            txtDetalleCompra.Visible = true;
            lblDetalleCompra.Visible = true;


            if (int.TryParse(txtDetalleCompra.Text, out int DetalleCompraID))
            {

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtEliminarCompra))
                {
                    MessageBox.Show("Ingrese un número de cliente valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    CompraService.EliminarDetalleCompra(DetalleCompraID,usuarioId);
                    MessageBox.Show("Compra detallada eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtDetalleCompra.Visible = false;
                    lblDetalleCompra.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la compra detallada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

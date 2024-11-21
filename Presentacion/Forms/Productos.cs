using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Presentacion.Forms;
using static Negocio.ProductoService;
using Negocio;
using System.Drawing.Text;
using static Presentacion.ValidacionesCapaPresentacion;

namespace Presentacion
{
    public partial class Productos : Form
    {
        private ModificarProductoFrm modificarProductoFrm;
        private ConexionConBD dbConnection;

        private int usuarioId;

        public Productos()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();

        }
        private void Actualizar()
        {
            Productos_Load(null, null);
        }
        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        private void CargarData()
        {
            try
            {

                DataTable result = SuperCapa.CargarTablaProductos();
                dgvProductos.DataSource = result;

            }
            catch (Exception ex)
            {
                MostrarError("cargar los productos en", ex);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoFrm agregarProductoFrm = new AgregarProductoFrm();
            agregarProductoFrm.ShowDialog();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && modificarProductoFrm != null && !modificarProductoFrm.IsDisposed)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                if (row.Cells["ProductoID"].Value != null &&
                   row.Cells["Nombre"].Value != null &&
                   row.Cells["Precio"].Value != null &&
                   row.Cells["Descripcion"].Value != null &&
                   row.Cells["Stock"].Value != null)

                {
                    try
                    {
                        Producto producto = new Producto
                        {

                            ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                            Nombre = row.Cells["Nombre"].Value.ToString(),
                            Precio = Convert.ToDecimal(row.Cells["Precio"].Value),
                            Descripcion = row.Cells["Descripcion"].Value.ToString(),
                            Stock = Convert.ToInt32(row.Cells["Stock"].Value)
                        };
                        modificarProductoFrm.SetProducto(producto);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (modificarProductoFrm == null || modificarProductoFrm.IsDisposed)
            {
                modificarProductoFrm = new ModificarProductoFrm(this);
                modificarProductoFrm.Show();
            }
            else
            {
                modificarProductoFrm.BringToFront();
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            txtEliminarProd.Visible = true;
            lblEliminarProd.Visible = true;

            if (int.TryParse(txtEliminarProd.Text, out int ProductoID))
            {

                try
                {
                    ProductoService.EliminarProducto(ProductoID, usuarioId);
                    MessageBox.Show("Producto eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtEliminarProd.Visible = false;
                    lblEliminarProd.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos Excel|*.xlsx",
                Title = "Seleccionar archivo Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                int usuarioId = AuthManager.Instance.GetUsuarioId();
                ProductoService.InsertarProductosDesdeExcel(rutaArchivo, usuarioId);

                MessageBox.Show("Productos insertados correctamente.");
            }
          
        }
    }
}
            
           
       



    

    



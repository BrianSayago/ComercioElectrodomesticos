using Datos;
using Negocio;
using Presentacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.ProveedorService;
using static Presentacion.ValidacionesCapaPresentacion;

namespace Presentacion
{
    public partial class Proveedores : Form
    {
        private ModificarProveedorFrm modificarProveedorFrm;
        private int usuarioId;


        public Proveedores()
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
            Proveedores_Load(null, null);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarData();
        }
        private void CargarData()
        {
            try
            {
                DataTable result = SuperCapa.CargarTablaProveedores();
                dgvProveedores.DataSource = result;

            }
            catch (Exception ex)
            {
                MostrarError("cargar los proveedores en", ex);
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && modificarProveedorFrm != null && !modificarProveedorFrm.IsDisposed)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];

                if (row.Cells["ProveedorID"].Value != null &&
                   row.Cells["Nombre"].Value != null &&
                   row.Cells["Direccion"].Value != null &&
                   row.Cells["Telefono"].Value != null &&
                   row.Cells["Email"].Value != null)
                {
                    try
                    {
                        Proveedor proveedor = new Proveedor
                        {

                            ProveedorID = Convert.ToInt32(row.Cells["ProveedorID"].Value),
                            Nombre = row.Cells["Nombre"].Value.ToString(),
                            Direccion = row.Cells["Direccion"].Value.ToString(),
                            Telefono = row.Cells["Telefono"].Value.ToString(),
                            Email = row.Cells["Email"].Value.ToString()
                        };
                        modificarProveedorFrm.SetProveedor(proveedor);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Algunas celdas están vacías o no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedorFrm agregarProveedorFrm = new AgregarProveedorFrm();
            agregarProveedorFrm.ShowDialog();

        }

        private void btnModificarProve_Click(object sender, EventArgs e)
        {
            if (modificarProveedorFrm == null || modificarProveedorFrm.IsDisposed)
            {
                modificarProveedorFrm = new ModificarProveedorFrm(this);
                modificarProveedorFrm.Show();
            }
            else
            {
                modificarProveedorFrm.BringToFront();
            }
        }
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            txtEliminarProve.Visible = true;
            lblEliminarProve.Visible = true;

            if (int.TryParse(txtEliminarProve.Text, out int ProveedorID))
            {

                try
                {
                    
                    ProveedorService.EliminarProveedor(ProveedorID,usuarioId);
                    MessageBox.Show("Proveedor eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtEliminarProve.Visible = false;
                    lblEliminarProve.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}

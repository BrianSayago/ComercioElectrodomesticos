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
using static Negocio.ClienteService;
using static Presentacion.ValidacionesCapaPresentacion;

namespace Presentacion
{
    public partial class Clientes : Form
    {
        private ModificarClienteFrm modificarClienteFrm;
        private ConexionConBD dbConnection;
        private Cliente cliente;
        private int usuarioId;
        public Clientes()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        private void CargarData()
        {
            try
            {
                DataTable result = SuperCapa.CargarTablaClientes();
                dgvClientes.DataSource = result;

            }
            catch (Exception ex)
            {
                MostrarError("cargar los clientes en", ex);
            }
        }
        private void Actualizar()
        {
            Clientes_Load(null, null);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && modificarClienteFrm != null && !modificarClienteFrm.IsDisposed)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                if (row.Cells["ClienteID"].Value != null &&
                   row.Cells["Nombre"].Value != null &&
                   row.Cells["Apellido"].Value != null &&
                   row.Cells["Direccion"].Value != null &&
                   row.Cells["Telefono"].Value != null &&
                   row.Cells["Email"].Value != null)

                {
                    try
                    {
                        Cliente cliente = new Cliente
                        {

                            ClienteID = Convert.ToInt32(row.Cells["ClienteID"].Value),
                            Nombre = row.Cells["Nombre"].Value.ToString(),
                            Apellido = row.Cells["Apellido"].Value.ToString(),
                            Direccion = row.Cells["Direccion"].Value.ToString(),
                            Telefono = row.Cells["Telefono"].Value.ToString(),
                            Email = row.Cells["Email"].Value.ToString()
                        };
                        modificarClienteFrm.SetCliente(cliente);

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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteFrm agregarClienteFrm = new AgregarClienteFrm();
            agregarClienteFrm.ShowDialog();
            Actualizar();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (modificarClienteFrm == null || modificarClienteFrm.IsDisposed)
            {
                modificarClienteFrm = new ModificarClienteFrm(this);
                modificarClienteFrm.Show();
            }
            else
            {
                modificarClienteFrm.BringToFront();
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            txtEliminarCliente.Visible = true;
            lblEliminarCliente.Visible = true;
            try
            {
                if (int.TryParse(txtEliminarCliente.Text, out int ClienteID))
                {
                    if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtEliminarCliente))
                    {
                        MessageBox.Show("Ingrese un número de cliente valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ClienteService.EliminarCliente(ClienteID, usuarioId);
                    MessageBox.Show("Cliente eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    txtEliminarCliente.Visible = false;
                    lblEliminarCliente.Visible = false;
                    FormularioUtilidades.LimpiarCampos(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

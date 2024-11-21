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
using static Negocio.ClienteService;
using static Negocio.ProveedorService;

namespace Presentacion.Forms
{
    public partial class ModificarProveedorFrm : Form
    {

        private Proveedores proveedorForm;
        private Proveedor _proveedor;
        private int usuarioId;
        public ModificarProveedorFrm(Proveedores proveedorForm)
        {
            InitializeComponent();
            this.proveedorForm = proveedorForm;
            usuarioId = AuthManager.Instance.GetUsuarioId();

        }

        public void SetProveedor(Proveedor proveedor)
        {
            _proveedor = proveedor;
            txtProovedorID.Text = _proveedor.ProveedorID.ToString();
            txtNombreProveedor.Text = _proveedor.Nombre;
            txtDireccionProv.Text = _proveedor.Direccion;
            txtTelProveedor.Text = _proveedor.Telefono;
            txtEmailProveedor.Text = _proveedor.Email;

        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                _proveedor.Nombre = txtNombreProveedor.Text;
                _proveedor.Direccion = txtDireccionProv.Text;
                _proveedor.Telefono = txtTelProveedor.Text;
                _proveedor.Email = txtEmailProveedor.Text;

                try
                {

                    ProveedorService.ModificarProveedor(_proveedor, usuarioId);
                    MessageBox.Show("Proveedor actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

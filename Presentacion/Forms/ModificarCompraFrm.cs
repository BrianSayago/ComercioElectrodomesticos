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
using static Negocio.CompraService;



namespace Presentacion.Forms
{
    public partial class ModificarCompraFrm : Form
    {
        ConexionConBD dbConnection;
        private Compras comprasForm;
        private Compra _compra;
        private int usuarioId;
        CompraService compraService;

        public ModificarCompraFrm(Compras comprasForm)
        {
            usuarioId = AuthManager.Instance.GetUsuarioId();
            InitializeComponent();
            this.comprasForm = comprasForm;
            LoadProveedores();
        }

        private void MostrarError(string operacion, Exception ex)
        {
            MessageBox.Show("Error al " + operacion + " el registro: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadProveedores()
        {
            try
            {

                DataTable result = SuperCapa.CargarProveedores();

                cmbProveedores.DataSource = result;
                cmbProveedores.DisplayMember = "Nombre";
                cmbProveedores.ValueMember = "ProveedorID";
            }
            catch (Exception ex)
            {
                MostrarError("cargar los proveedores", ex);
            }
        }

        public void SetCompra(Compra compra)
        {
            _compra = compra;
            txtCompraID.Text = _compra.CompraID.ToString();
            cmbProveedores.SelectedValue = _compra.ProveedorID;
            dtpFecha.Value = _compra.FechaCompra;
            txtTotal.Text = _compra.Total.ToString();
        }
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                _compra.CompraID = Convert.ToInt32(txtCompraID.Text);
                _compra.ProveedorID = Convert.ToInt32(cmbProveedores.SelectedValue);
                _compra.FechaCompra = dtpFecha.Value;
                _compra.Total = Convert.ToDecimal(txtTotal.Text);

                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtTotal.Text))
                {
                    MessageBox.Show("Ingrese un número del total valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {

                    CompraService.ModificarCompra(_compra);
                    SuperCapa.RegistrarHistorialModificaciones(_compra.CompraID);
                    MessageBox.Show("Compra actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace Presentacion.Forms
{
    public partial class AgregarProveedorFrm : Form
    {

        private int usuarioId;
        public AgregarProveedorFrm()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void RegistrarMovimientoInsercionProveedor(int usuarioId, string nombre, string email)
        {
            try
            {
                string detalle = $"Proveedor insertado: Nombre = {nombre}, Email = {email}";
                SuperCapa.RegistrarMovimientoProveedor(usuarioId, "Proveedores", "INSERT", detalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el movimiento de inserción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {


                string nombre = txtNombreProveedor.Text.Trim();
                string direccion = txtDireccionProv.Text.Trim();
                string telefono = txtTelProveedor.Text.Trim();
                string email = txtEmailProveedor.Text.Trim();


                if (!ValidacionesCapaPresentacion.ValidarTexto(txtNombreProveedor))
                {
                    MessageBox.Show("Ingrese un nombre de proveedor válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarEspaciosBlancos(txtDireccionProv))
                {
                    MessageBox.Show("Complete con la dirección de el proveedor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtTelProveedor))
                {
                    MessageBox.Show("Ingrese un número de télefono valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarEmail(txtEmailProveedor))
                {
                    MessageBox.Show("Ingrese un email valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                ProveedorService.InsertarProveedor(nombre, direccion, telefono, email);
                RegistrarMovimientoInsercionProveedor(usuarioId, nombre, email);

                MessageBox.Show("Proveedor agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtDireccionProv_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtTelProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtEmailProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }
    }
}

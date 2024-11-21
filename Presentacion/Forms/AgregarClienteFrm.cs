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
using static Presentacion.ValidacionesCapaPresentacion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Forms
{
    public partial class AgregarClienteFrm : Form
    {

        private int usuarioId;
        AgregarClienteFrm agregarClienteFrm;
        
        public AgregarClienteFrm()
        {
            InitializeComponent();        
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

      
        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreCliente.Text.Trim();
                string apellido = txtApellidoCliente.Text.Trim();
                string direccion = txtDireCliente.Text.Trim();
                string telefono = txtTelCliente.Text.Trim();
                string email = txtEmailCliente.Text.Trim();


                if (!ValidacionesCapaPresentacion.ValidarTexto(txtNombreCliente))
                {
                    MessageBox.Show("Ingrese un nombre de cliente válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarTexto(txtApellidoCliente))
                {
                    MessageBox.Show("Ingrese un apellido cliente válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarEspaciosBlancos(txtDireCliente))
                {
                    MessageBox.Show("Complete con la dirección de el cliente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtTelCliente))
                {
                    MessageBox.Show("Ingrese un número de télefono valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarEmail(txtEmailCliente))
                {
                    MessageBox.Show("Ingrese un email valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                ClienteService.InsertarCliente(nombre, apellido, direccion, telefono, email);
                ClienteService.RegistrarMovimientoInsercionCliente(usuarioId, nombre, apellido, email);
                MessageBox.Show("Cliente agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormularioUtilidades.LimpiarCampos(this);
                this.Close();

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtApellidoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtDireCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtTelCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtEmailCliente_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }
    }
}
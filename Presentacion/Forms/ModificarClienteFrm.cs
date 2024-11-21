using Datos;
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
using static Negocio.ClienteService;


namespace Presentacion.Forms
{
    public partial class ModificarClienteFrm : Form
    {

        private Clientes clienteForm;
        private Cliente _cliente;
        private int usuarioId;
        
        public ModificarClienteFrm(Clientes clienteForm)
        {
            InitializeComponent();
            this.clienteForm = clienteForm;
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }



        public void SetCliente(Cliente cliente)
        {
            _cliente = cliente;
            txtClienteID.Text = _cliente.ClienteID.ToString();
            txtNombreCliente.Text = _cliente.Nombre;
            txtApellidoCliente.Text = _cliente.Apellido;
            txtDireCliente.Text = _cliente.Direccion;
            txtTelCliente.Text = _cliente.Telefono;
            txtEmailCliente.Text = _cliente.Email;

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                _cliente.Nombre = txtNombreCliente.Text;
                _cliente.Apellido = txtApellidoCliente.Text;
                _cliente.Direccion = txtDireCliente.Text;
                _cliente.Telefono = txtTelCliente.Text;
                _cliente.Email = txtEmailCliente.Text;

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtClienteID))
                {
                    MessageBox.Show("Ingrese un numero de cliente válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarTexto(txtNombreCliente))
                {
                    MessageBox.Show("Ingrese un nombre de cliente válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarTexto(txtApellidoCliente))
                {
                    MessageBox.Show("Ingrese un apellido de cliente válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarEspaciosBlancos(txtDireCliente))
                {
                    MessageBox.Show("Ingrese una dirección.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtTelCliente))
                {
                    MessageBox.Show("Ingrese un número de telefono del cliente válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarEmail(txtEmailCliente))
                {
                    MessageBox.Show("Ingrese un email valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {

                    ClienteService.ModificarCliente(_cliente, usuarioId);
                    MessageBox.Show("Cliente actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClienteID_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
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

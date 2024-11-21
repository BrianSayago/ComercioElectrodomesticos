using Datos;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
using static Negocio.ProductoService;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Presentacion.Forms
{
    public partial class AgregarProductoFrm : Form
    {
        private int usuarioId;
        
        public AgregarProductoFrm()
        {
            InitializeComponent();
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }

        private void RegistrarMovimientoInsercionProducto(int usuarioId, string nombre, string stock, string descripcion, string precio)
        {
            try
            {
                string detalle = $"Producto insertado: Nombre = {nombre}, Stock = {stock}, Descripción = {descripcion}, Precio = {precio}";
                SuperCapa.RegistrarMovimiento(usuarioId, "Productos", "INSERT", detalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el movimiento de inserción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnConfirmarProducto_Click(object sender, EventArgs e)
        {
            try
            {


                string nombre = txtNombreProducto.Text.Trim();
                string stockText = txtStockProducto.Text.Trim();
                string descripcion = txtInfoProducto.Text.Trim();
                string precioText = txtPrecioProducto.Text.Trim();


                if (!ValidacionesCapaPresentacion.ValidarTexto(txtNombreProducto))
                {
                    MessageBox.Show("Ingrese un nombre de producto válido (solo letras y espacios).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarTexto(txtInfoProducto))
                {
                    MessageBox.Show("Complete la descripción de el producto.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!int.TryParse(precioText, out int precio) || precio < 0)
                {
                    MessageBox.Show("Formato de precio incorrecto o el precio es negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtPrecioProducto))
                {
                    return;
                }

                if (!int.TryParse(stockText, out int stock) || stock < 0)
                {
                    MessageBox.Show("Formato de stock incorrecto o el stock es negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidacionesCapaPresentacion.ValidarSoloNumeros(txtStockProducto))
                {
                    MessageBox.Show("Ingrese un stock valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProductoService.InsertarProducto(nombre, precio, descripcion, stock);
                RegistrarMovimientoInsercionProducto(usuarioId, nombre, stockText, descripcion, precioText);

                MessageBox.Show("Producto agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtPrecioProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtInfoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }

        private void txtStockProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacionesCapaPresentacion.DeshabilitarCopiarPegar(e);
        }
    }
}
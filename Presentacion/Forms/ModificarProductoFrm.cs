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
using static Negocio.ProductoService;

namespace Presentacion.Forms
{
    public partial class ModificarProductoFrm : Form
    {
        private int usuarioId;
        private Producto _producto;
        private Productos productoForm;

        public ModificarProductoFrm(Productos productoForm)
        {
            InitializeComponent();
            this.productoForm = productoForm;
            usuarioId = AuthManager.Instance.GetUsuarioId();
        }


        public void SetProducto(Producto producto)
        {
            _producto = producto;
            txtProductoID.Text = _producto.ProductoID.ToString();
            txtNombreProducto.Text = _producto.Nombre;
            txtPrecioProducto.Text = _producto.Precio.ToString();
            txtInfoProducto.Text = _producto.Descripcion;
            txtStockProducto.Text = _producto.Stock.ToString();
        }

        private bool ConfirmarModificacion()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar este producto?",
                                                  "Confirmar Modificación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                MessageBox.Show("Debe ingresar un precio de producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtInfoProducto.Text))
            {
                MessageBox.Show("Debe ingresar una información del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStockProducto.Text))
            {
                MessageBox.Show("Debe ingresar el stock del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarFormatoDecimal()
        {
            if (!decimal.TryParse(txtPrecioProducto.Text, out _))
            {
                MessageBox.Show("El precio del producto debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStockProducto.Text, out _))
            {
                MessageBox.Show("El stock del producto debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _producto.Nombre = txtNombreProducto.Text;
                _producto.Precio = Convert.ToDecimal(txtPrecioProducto.Text);
                _producto.Descripcion = txtInfoProducto.Text;
                _producto.Stock = Convert.ToInt32(txtStockProducto.Text);

                if (!ValidacionesCapaPresentacion.ValidarSoloPalabras(txtNombreProducto))
                {
                    MessageBox.Show("Ingrese un nombre de producto valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtPrecioProducto.Text))
                {
                    MessageBox.Show("Ingrese un precio de producto valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarSoloPalabras(txtInfoProducto))
                {
                    MessageBox.Show("Ingrese una descripcion de producto valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidacionesCapaPresentacion.ValidarNumeroEntero(txtStockProducto.Text))
                {
                    MessageBox.Show("Ingrese un stock de producto valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarCamposObligatorios()) return;
                if (!ValidarFormatoDecimal()) return;
                if (ConfirmarModificacion())
                {
                    try
                    {
                        ProductoService.ModificarProducto(_producto);
                        ProductoService.RegistrarHistorialModificacionesProducto(_producto, usuarioId);
                        MessageBox.Show("Producto actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La modificación ha sido cancelada.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        }
    }

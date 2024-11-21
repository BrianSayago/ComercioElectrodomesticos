using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Presentacion
{
    internal class ValidacionesCapaPresentacion
    {
        public static bool ValidarEspaciosBlancos(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
        public static bool ValidarSoloPalabras(TextBox textBox)
        {
            string texto = textBox.Text.Trim();
            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$");
        }
        public static bool ValidarSoloNumeros(TextBox textBox)
        {
            string texto = textBox.Text.Trim();
            return Regex.IsMatch(texto, @"^\d+$");
        }
        public static bool ValidarTexto(TextBox textBox)
        {
            return ValidarEspaciosBlancos(textBox) && ValidarSoloPalabras(textBox);
        }
        public static bool ValidarFecha(string fechaStr, out DateTime fecha)
        {
            return DateTime.TryParseExact(fechaStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
        }
        public static bool ValidarPrecio(string precioText, out decimal precio)
        {
            precio = 0;

            if (string.IsNullOrWhiteSpace(precioText))
            {
                MessageBox.Show("El precio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(precioText, out precio))
            {
                MessageBox.Show("Formato de precio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidarEmail(TextBox textBox)
        {
            string email = textBox.Text.Trim();
            return email.Contains("@") && !email.Contains(" ");
        }

        public static void DeshabilitarCopiarPegar(KeyEventArgs e)
        {
            // Verifica si se presiona Ctrl+C, Ctrl+V o Ctrl+X
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true; // Evita que se ejecute el comando
            }
        }

        public static bool ValidarNumeroEntero(string input)
        {
            // Intentamos convertir la entrada a un número entero
            if (int.TryParse(input, out int valor))
            {
                // Verificamos que el valor sea mayor a 0
                if (valor > 0)
                {
                    return true; // La validación es correcta
                }
                else
                {
                    MessageBox.Show("El valor debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Si no es un número válido
                MessageBox.Show("El valor ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static class FormularioUtilidades
        {
            public static void LimpiarCampos(Control control)
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    else if (ctrl is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                    else if (ctrl is ListBox listBox)
                    {
                        listBox.Items.Clear();
                    }
                    else if (ctrl is CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

    }
}

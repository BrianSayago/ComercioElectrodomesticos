using ClosedXML.Excel;
using Datos;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.ClienteService;
using static Negocio.CompraService;
using static Negocio.ProductoService;
using static Negocio.UsuarioService;


namespace Negocio
{
    public class ProductoService
    {
        public class Producto
        {
            public int ProductoID { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }

        }

        private static void RegistrarMovimientoInsercionProducto(int usuarioId, string nombre, string stock, string descripcion, string precio)
        {

            string detalle = $"Producto insertado: Nombre = {nombre}, Stock = {stock}, Descripción = {descripcion}, Precio = {precio}";
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                           "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Productos"),
            new SqlParameter("@Accion", "INSERT"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };

            using (SqlConnection connection = new SqlConnection("Data Source = KernelOS-PC\\SQLEXPRESS;Initial Catalog = ElectrodomesticosBD;Integrated Security = True;TrustServerCertificate=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertarProducto(string nombre, decimal precio, string descripcion, int stock)
        {
          
                string[] columns = { "Nombre", "Precio", "Descripcion", "Stock" };
                string[] values = { "@Nombre", "@Precio", "@Descripcion", "@Stock" };

                string query = $"INSERT INTO Productos ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})";

                SqlParameter[] parameters = {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Precio", precio),
                new SqlParameter("@Descripcion", descripcion),
                new SqlParameter("@Stock", stock)

                };

                ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void ModificarProducto(Producto producto)
        {
            string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock WHERE ProductoID = @ProductoID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Nombre", producto.Nombre),
            new SqlParameter("@Precio", producto.Precio),
            new SqlParameter("@Descripcion", producto.Descripcion),
            new SqlParameter("@Stock", producto.Stock),
            new SqlParameter("@ProductoID", producto.ProductoID)
            };

            ConexionConBD.ExecuteNonQuery (query, parameters);
        }

        public static void EliminarProducto(int ProductoID, int usuarioId)
        {
            
            usuarioId = AuthManager.Instance.GetUsuarioId();

            string query = "DELETE FROM Productos WHERE ProductoID = @ProductoID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ProductoID", ProductoID)
            };

            ConexionConBD.ExecuteNonQuery(query,parameters);

            string detalleCambio = $"Eliminación de producto: ProductoID = {ProductoID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Productos"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

        public static void InsertarProductosDesdeExcel(string rutaArchivo, int usuarioId)
        {
            usuarioId = AuthManager.Instance.GetUsuarioId();
            DataTable productos = LeerExcel(rutaArchivo);

            foreach (DataRow row in productos.Rows)
            {
                string nombre = row["Nombre"].ToString();
                string descripcion = row["Descripcion"].ToString();
                decimal precio = Convert.ToDecimal(row["Precio"]);
                int stock = Convert.ToInt32(row["Stock"]);

                InsertarProducto(nombre, precio, descripcion, stock);
                RegistrarMovimientoInsercionProducto(usuarioId, nombre, stock.ToString(), descripcion, precio.ToString());
            }
        }

        private static DataTable LeerExcel(string rutaArchivo)
        {
            DataTable dataTable = new DataTable();

            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet(1);

                bool primeraFila = true;
                foreach (var row in worksheet.Rows())
                {
                    if (primeraFila)
                    {
                        foreach (var cell in row.Cells())
                        {
                            dataTable.Columns.Add(cell.Value.ToString());
                        }
                        primeraFila = false;
                    }
                    else
                    {
                        dataTable.Rows.Add();
                        int i = 0;
                        foreach (var cell in row.Cells())
                        {
                            dataTable.Rows[dataTable.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
            }

            return dataTable;
        }

        public static void RegistrarHistorialModificacionesProducto(Producto producto, int usuarioId)
        {
            usuarioId = AuthManager.Instance.GetUsuarioId();
            string detalle = $"Producto modificado: ID = {producto.ProductoID}, Nombre = {producto.Nombre}, Precio = {producto.Precio}, Descripción = {producto.Descripcion}, Stock = {producto.Stock}";
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                           "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Productos"),
            new SqlParameter("@Accion", "UPDATE"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };

        }


    }
}



using DocumentFormat.OpenXml.Office2013.Excel;

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class SuperCapa
    {
        public static DataTable CargarProductos()
        {
            string query = "SELECT ProductoID, Nombre, Precio, Stock FROM Productos";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarProveedores()
        {
            string query = "SELECT ProveedorID, Nombre FROM Proveedores";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarClientes()
        {
            string query = "SELECT ClienteID, Nombre FROM Clientes";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaClientes()
        {
            string query = "SELECT * FROM Clientes";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaCompras()
        {
            string query = "SELECT * FROM Compras";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaVentas()
        {
            string query = "SELECT * FROM Ventas";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaDetalleVentas()
        {
            string query = "SELECT * FROM DetalleVenta";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaProductos()
        {
            string query = "SELECT * FROM Productos";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaProveedores()
        {
            string query = "SELECT * FROM Proveedores";
            return ConexionConBD.ExecuteQuery(query);
        }


        public static DataTable CargarTablaDetalleCompras()
        {
            string query = "SELECT * FROM DetalleCompra";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaHV()
        {
            string query = "SELECT * FROM HistoricoVentasCompras";
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable CargarTablaRM()
        {
            string query = "SELECT * FROM RegistroCambios";
            return ConexionConBD.ExecuteQuery(query);
        }



        public static int InsertarCompra(int proveedorId, DateTime fechaCompra, decimal total, int usuarioId)
        {
            string query = "INSERT INTO Compras (ProveedorID, FechaCompra, Total, UsuarioID) " +
                           "VALUES (@ProveedorID, @FechaCompra, @Total, @UsuarioID); " +
                           "SELECT SCOPE_IDENTITY();";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@ProveedorID", proveedorId),
            new SqlParameter("@FechaCompra", fechaCompra),
            new SqlParameter("@Total", total),
            new SqlParameter("@UsuarioID", usuarioId)
            };

            return Convert.ToInt32(ConexionConBD.ExecuteScalar(query, parametros));
        }
        public static void InsertarDetalleCompra(int compraId, int productoId, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            string query = "INSERT INTO DetalleCompra (CompraID, ProductoID, Cantidad, PrecioUnitario, Subtotal) " +
                           "VALUES (@CompraID, @ProductoID, @Cantidad, @PrecioUnitario, @Subtotal)";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@CompraID", compraId),
            new SqlParameter("@ProductoID", productoId),
            new SqlParameter("@Cantidad", cantidad),
            new SqlParameter("@PrecioUnitario", precioUnitario),
            new SqlParameter("@Subtotal", subtotal)
            };

            ConexionConBD.ExecuteNonQuery(query, parametros);
        }
        public static void RegistrarMovimiento(int usuarioId, string tabla, string accion, string detalle)
        {
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                           "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", tabla),
            new SqlParameter("@Accion", accion),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };

            ConexionConBD.ExecuteNonQuery(query, parametros);
        }

        public static void RegistrarMovimientoProveedor(int usuarioId, string tabla, string accion, string detalle)
        {
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                               "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UsuarioID", usuarioId),
                new SqlParameter("@Tabla", "Proveedores"),
                new SqlParameter("@Accion", "INSERT"),
                new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@Detalle", detalle)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static int InsertarVenta(int clienteId, DateTime fechaVenta, decimal total, int usuarioId)
        {
            string query = "INSERT INTO Ventas (ClienteID, FechaVenta, Total, UsuarioID) " +
                           "VALUES (@ClienteID, @FechaVenta, @Total, @UsuarioID); " +
                           "SELECT SCOPE_IDENTITY();";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@ClienteID", clienteId),
            new SqlParameter("@FechaVenta", fechaVenta),
            new SqlParameter("@Total", total),
            new SqlParameter("@UsuarioID", usuarioId)
            };

            return Convert.ToInt32(ConexionConBD.ExecuteScalar(query, parametros));
        }

        public static void InsertarDetalleVenta(int ventaId, int productoId, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            string query = "INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal) " +
                           "VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @Subtotal)";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@VentaID", ventaId),
            new SqlParameter("@ProductoID", productoId),
            new SqlParameter("@Cantidad", cantidad),
            new SqlParameter("@PrecioUnitario", precioUnitario),
            new SqlParameter("@Subtotal", subtotal)
            };

            ConexionConBD.ExecuteNonQuery(query, parametros);
        }

        public static void RegistrarHistorialVenta(int ventaId, int clienteId, decimal total, DateTime fechaVenta)
        {
            string detalleVenta = $"Venta realizada: ID = {ventaId}, ClienteID = {clienteId}, Total = {total}, Fecha = {fechaVenta}";
            string query = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                        "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Tipo", "Venta"),
            new SqlParameter("@ID", ventaId),
            new SqlParameter("@Fecha", fechaVenta),
            new SqlParameter("@Detalle", detalleVenta)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void RegistrarRegistroCambio(int usuarioId, string tabla, string accion, int ventaId, int clienteId, decimal total, DateTime fechaVenta)
        {
            string detalle = $"Venta realizada: ID = {ventaId}, ClienteID = {clienteId}, Total = {total}, Fecha = {fechaVenta}";
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                           "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", tabla),
            new SqlParameter("@Accion", accion),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };

            ConexionConBD.ExecuteNonQuery(query, parametros);
        }

        public static void RegistrarHistorialModificaciones(int compraId)
        {
            string detalle = $"Se ha modificado la compra con ID: {compraId} el {DateTime.Now}.";
            string query = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                    "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Tipo", "Compra"),
                new SqlParameter("@ID", compraId),
                new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@Detalle", detalle)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);
        }
        public static void RegistrarHistorialModificacionesCompra(int detalleCompraId)
        {
            string detalle = $"Se ha modificado el detalle de la compra con ID: {detalleCompraId} el {DateTime.Now}.";

            string query = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                    "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Tipo", "DetalleVenta"),
            new SqlParameter("@ID", detalleCompraId),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void RegistrarHistorialModificacionesDetalleVenta(int detalleVentaId)
        {
            string detalle = $"Se ha modificado el detalle de la venta con ID: {detalleVentaId} el {DateTime.Now}.";

            string query = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                    "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Tipo", "DetalleVenta"),
            new SqlParameter("@ID", detalleVentaId),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalle)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);

        }

        public static void RegistrarHistorialModificacionesVenta(int ventaId)
        {
            string detalle = $"Se ha modificado la venta con ID: {ventaId} el {DateTime.Now}.";
            string query = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                    "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Tipo", "Venta"),
                new SqlParameter("@ID", ventaId),
                new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@Detalle", detalle)
            };
            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static int? ValidarUsuario(string nombreUsuario, string contrasena)
        {
            string query = "SELECT UsuarioID FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
            SqlParameter[] parametros = {
            new SqlParameter("@NombreUsuario", nombreUsuario),
            new SqlParameter("@Contrasena", contrasena)
        };

            DataTable result = ConexionConBD.ExecuteQuery(query, parametros);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["UsuarioID"]);
            }
            else
            {
                return null;
            }
        }

        public static string ObtenerEmailPorUsuarioID(int usuarioID)
        {
            string query = "SELECT Email FROM Usuarios WHERE UsuarioID = @UsuarioID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioID)
            };

            DataTable result = ConexionConBD.ExecuteQuery(query, parameters);

            if (result == null || result.Rows.Count == 0)
            {
                return null;
            }

            return result.Rows[0]["Email"].ToString();
        }

        public static string ObtenerContrasenaPorCorreo(string email)
        {
            string query = "SELECT Contrasena FROM Usuarios WHERE Email = @Email";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Email", email)
            };

            DataTable result = ConexionConBD.ExecuteQuery(query, parameters);

            if (result == null || result.Rows.Count == 0)
            {
                return null;
            }

            return result.Rows[0]["Contrasena"].ToString();
        }
    }
}


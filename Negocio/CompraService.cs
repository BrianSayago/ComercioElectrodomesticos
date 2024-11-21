using Azure.Core;
using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.UsuarioService;
using static Negocio.VentaService;

namespace Negocio
{
    public class CompraService
    {

        public class Compra
        {
            public int CompraID { get; set; }
            public int ProveedorID { get; set; }
            public DateTime FechaCompra { get; set; }
            public decimal Total { get; set; }
            public int UsuarioID { get; set; }
        }

        public class DetalleCompra
        {
            public int DetalleCompraID { get; set; }
            public int CompraID { get; set; }
            public int ProductoID { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal { get; set; }
        }

        public static void ModificarCompra(Compra compra)
        {
            string query = "UPDATE Compras SET ProveedorID = @ProveedorID, FechaCompra = @FechaCompra, Total = @Total WHERE CompraID = @CompraID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ProveedorID", compra.ProveedorID),
            new SqlParameter("@FechaCompra", compra.FechaCompra),
            new SqlParameter("@Total", compra.Total),
            new SqlParameter("@CompraID", compra.CompraID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void EliminarCompra(int CompraID, int usuarioId)
        {
            string query = "DELETE FROM Compras WHERE CompraID = @CompraID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CompraID", CompraID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de detalle de venta: DetalleVentaID = {CompraID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Compras"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

        public static void ModificarDetalleCompra(DetalleCompra detalleCompra)
        {
            string query = "UPDATE DetalleCompra SET CompraID = @CompraID, ProductoID = @ProductoID, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Subtotal = @Subtotal WHERE DetalleCompraID = @DetalleCompraID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CompraID", detalleCompra.CompraID),
            new SqlParameter("@ProductoID", detalleCompra.ProductoID),
            new SqlParameter("@Cantidad", detalleCompra.Cantidad),
            new SqlParameter("@PrecioUnitario", detalleCompra.PrecioUnitario),
            new SqlParameter("@Subtotal", detalleCompra.Subtotal),
            new SqlParameter("@DetalleCompraID", detalleCompra.DetalleCompraID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void EliminarDetalleCompra(int DetalleCompraID, int usuarioId)
        {
            string query = "DELETE FROM DetalleCompra WHERE DetalleCompraID = @DetalleCompraID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@DetalleCompraID", DetalleCompraID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de detalle de compra: DetalleCompraID = {DetalleCompraID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "DetalleCompra"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

        public static void RegistrarHistorialCompra(int compraId, int proveedorId, decimal total, DateTime fechaCompra)
        {
            string detalleCompra = $"Compra realizada: ID = {compraId}, ProveedorID = {proveedorId}, Total = {total}, Fecha = {fechaCompra}";
            string queryHistorialCompra = "INSERT INTO HistoricoVentasCompras (Tipo, ID, Fecha, Detalle) " +
                                         "VALUES (@Tipo, @ID, @Fecha, @Detalle)";

            SqlParameter[] historialCompraParams = new SqlParameter[]
            {
            new SqlParameter("@Tipo", "Compra"),
            new SqlParameter("@ID", compraId),
            new SqlParameter("@Fecha", fechaCompra),
                new SqlParameter("@Detalle", detalleCompra)
            };

            ConexionConBD.ExecuteNonQuery(queryHistorialCompra, historialCompraParams);
        }

        public static void RegistrarRegistroCambioCompra(int compraId, string tabla, string accion, int proveedorId, decimal total, DateTime fechaCompra)
        {
            int usuarioId = 0;
            usuarioId = AuthManager.Instance.GetUsuarioId();

            string detalleCambio = $"Compra realizada: ID = {compraId}, ProveedorID = {proveedorId}, Total = {total}, Fecha = {fechaCompra}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", tabla),
            new SqlParameter("@Accion", accion),
            new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }


    }
}

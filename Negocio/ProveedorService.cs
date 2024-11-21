using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.ClienteService;

namespace Negocio
{
    public class ProveedorService
    {
        private ConexionConBD ConexionConBD;


        public class Proveedor
        {
            public int ProveedorID { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
        }

        public static void InsertarProveedor(string nombre, string direccion, string telefono, string email)
        {

            string[] columns = { "Nombre", "Direccion", "Telefono", "Email" };
            string[] values = { "@Nombre", "@Direccion", "@Telefono", "@Email" };

            string query = $"INSERT INTO Proveedores ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})";

            SqlParameter[] parameters = {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Direccion", direccion),
                new SqlParameter("@Telefono", telefono),
                new SqlParameter("@Email", email)
                };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void ModificarProveedor(Proveedor proveedor, int usuarioId)
        {
            string query = "UPDATE Proveedores SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE ProveedorID = @ProveedorID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Nombre", proveedor.Nombre),
            new SqlParameter("@Direccion", proveedor.Direccion),
            new SqlParameter("@Telefono", proveedor.Telefono),
            new SqlParameter("@Email", proveedor.Email),
            new SqlParameter("@ProveedorID", proveedor.ProveedorID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Modificacion de proveedor: Proveedor = {proveedor.ProveedorID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Proveedores"),
            new SqlParameter("@Accion", "Modificación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }
        public static void EliminarProveedor(int ProveedorID, int usuarioId)
        {
            string query = "DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ProveedorID", ProveedorID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de proveedor: ProveedorID = {ProveedorID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Proveedores"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

    }
}

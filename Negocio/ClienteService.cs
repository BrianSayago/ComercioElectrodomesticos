using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.ClienteService;
using static Negocio.VentaService;

namespace Negocio
{
    public class ClienteService
    {
        
        public class Cliente
        {
            public int ClienteID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
        }

        public static void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string email)
        {

            string[] columns = { "Nombre", "Apellido", "Direccion", "Telefono", "Email" };
            string[] values = { "@Nombre", "@Apellido", "@Direccion", "@Telefono", "@Email" };

            string query = $"INSERT INTO Clientes ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})";

            SqlParameter[] parameters = {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Apellido", apellido),
                new SqlParameter("@Direccion", direccion),
                new SqlParameter("@Telefono", telefono),
                new SqlParameter("@Email", email)

                };

            ConexionConBD.ExecuteNonQuery(query, parameters);

        }

        public static void ModificarCliente(Cliente cliente, int usuarioId)
        {
            string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono, Email = @Email WHERE ClienteID = @ClienteID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Nombre", cliente.Nombre),
            new SqlParameter("@Apellido", cliente.Apellido),
            new SqlParameter("@Direccion", cliente.Direccion),
            new SqlParameter("@Telefono", cliente.Telefono),
            new SqlParameter("@Email", cliente.Email),
            new SqlParameter("@ClienteID", cliente.ClienteID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Modificacion de cliente: ClienteID = {cliente.ClienteID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Clientes"),
            new SqlParameter("@Accion", "Modificación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);


        }

        public static void EliminarCliente(int ClienteID, int usuarioId)
        {
            string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ClienteID", ClienteID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de cliente: ClienteID = {ClienteID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Clientes"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

        public static void RegistrarMovimientoInsercionCliente(int usuarioId, string nombre, string apellido, string email)
        {

            string detalle = $"Cliente insertado: Nombre = {nombre}, Apellido = {apellido}, Email = {email}";
            string query = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                           "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UsuarioID", usuarioId),
                new SqlParameter("@Tabla", "Clientes"),
                new SqlParameter("@Accion", "INSERT"),
                new SqlParameter("@Fecha", DateTime.Now),
                new SqlParameter("@Detalle", detalle)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }
    }

    
}

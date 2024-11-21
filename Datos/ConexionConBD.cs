using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Datos

{
    public class ConexionConBD
    {
        static string connectionString;
        static SqlConnection ConexionSQL;
        static SqlCommand Orden;
        static SqlDataReader Lector;


        private static void ConectarBD()
        {
            connectionString = "Data Source = KernelOS-PC\\SQLEXPRESS;Initial Catalog = ElectrodomesticosBD;Integrated Security = True;TrustServerCertificate=True"; ;
            ConexionSQL = new SqlConnection(connectionString);
            try
            {
                ConexionSQL.Open();
            }
            catch
            {

            }
        }

        private static void CerrarBD()
        {
            ConexionSQL.Close();
        }


        public static void EjecutaQuery(string dame_query)
        {
            ConectarBD();
            SqlCommand ejecuta = new SqlCommand(dame_query, ConexionSQL);
            ejecuta.ExecuteNonQuery();
            CerrarBD();
        }



        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            ConectarBD();

            using (SqlCommand command = new SqlCommand(query, ConexionSQL))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
                CerrarBD();
            }
        }
            
        

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            ConectarBD();
            DataTable resultado = new DataTable();

            using (SqlCommand Orden = new SqlCommand(query, ConexionSQL))
            {
                if (parameters != null)
                {
                    Orden.Parameters.AddRange(parameters);
                }

                using (SqlDataReader Lector = Orden.ExecuteReader())
                {
                    resultado.Load(Lector);
                }
            }

            CerrarBD();
            return resultado;
        }

        public static int ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public static DataTable ObtenerVCPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = "SELECT * FROM HistoricoVentasCompras WHERE Fecha BETWEEN @FechaInicio AND @FechaFin";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FechaInicio", fechaInicio),
            new SqlParameter("@FechaFin", fechaFin)
            };

            return ExecuteQuery(query, parameters);  
        }

        public static DataTable ObtenerMovimientosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = "SELECT * FROM RegistroCambios WHERE Fecha BETWEEN @FechaInicio AND @FechaFin";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FechaInicio", fechaInicio),
            new SqlParameter("@FechaFin", fechaFin)
            };

            return ExecuteQuery(query, parameters);
        }


    }
}


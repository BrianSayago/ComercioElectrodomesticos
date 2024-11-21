using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioService
    {
        private ConexionConBD ConexionConBD;
        public class Usuario
        {
            public int UsuarioID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
        }
        public Usuario ObtenerUsuarioPorID(int usuarioID)
        {
          
            string query = "SELECT Nombre, Apellido FROM Usuarios WHERE UsuarioID = @UsuarioID";
            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@UsuarioID", usuarioID)
            };   

            DataTable resultado = ConexionConBD.ExecuteQuery(query, parameters);

            if (resultado.Rows.Count > 0)
            {
                DataRow row = resultado.Rows[0];
                return new Usuario
                {
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString()
                };
            }

            return null; 
        }
    }
}

       


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
    public class HistorialService
    {

        private ConexionConBD ConexionConBD;
        public static DataTable FiltrarVCPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
            }

            return ConexionConBD.ObtenerVCPorFecha(fechaInicio, fechaFin);
        }

        public static DataTable ObtenerTodasLasVentasCompras()
        {
            string query = "SELECT * FROM HistoricoVentasCompras"; // Consulta sin filtros de fecha
            return ConexionConBD.ExecuteQuery(query);
        }

        public static DataTable FiltrarMovimientosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
            }

            return ConexionConBD.ObtenerMovimientosPorFecha(fechaInicio, fechaFin);
        }

        public static DataTable ObtenerTodosLosMovimientos()
        {
            string query = "SELECT * FROM RegistroCambios"; // Consulta sin filtros de fecha
            return ConexionConBD.ExecuteQuery(query);
        }



    }
}

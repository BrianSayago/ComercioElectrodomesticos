using Datos;
using Microsoft.Data.SqlClient;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.ProductoService;
using static Negocio.VentaService;
using iText.Layout.Properties;
using iText.IO.Image;
using System.Resources;

namespace Negocio
{
    public class VentaService
    {
        private ConexionConBD ConexionConBD;


        public class Venta
        {
            public int VentaID { get; set; }
            public int ClienteID { get; set; }
            public DateTime FechaVenta { get; set; }
            public decimal Total { get; set; }
            public int UsuarioID { get; set; }
        }

        public class DetalleVenta
        {
            public int DetalleVentaID { get; set; }
            public int VentaID { get; set; }
            public int ProductoID { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal { get; set; }
        }

        public static List<DetalleVenta> ObtenerDetalleVenta(int ventaId)
        {
            string query = "SELECT ProductoID, Cantidad, PrecioUnitario, Subtotal FROM DetalleVenta WHERE VentaID = @VentaID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@VentaID", ventaId)
            };

            DataTable dt = ConexionConBD.ExecuteQuery(query, parameters);
            List<DetalleVenta> detalles = new List<DetalleVenta>();


            foreach (DataRow row in dt.Rows)
            {
                detalles.Add(new DetalleVenta
                {
                    ProductoID = Convert.ToInt32(row["ProductoID"]),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"]),
                    Subtotal = Convert.ToDecimal(row["Subtotal"])
                });
            }

            return detalles;
        }

        public static void GenerarRemitoPDF(int ventaId, string clienteNombre, decimal total, DateTime fechaVenta, List<DetalleVenta> detalles)
        {
            try
            {
                string folderPath = @"C:\Remitos";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, $"Remito_Venta_{ventaId}.pdf");
                string fecha = DateTime.Now.ToString("dd MMMM yyyy");

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdfDoc = new PdfDocument(writer))
                    {
                        {
                            using (Document document = new Document(pdfDoc))
                            {
                                Paragraph title = new Paragraph("Remito de Venta")
                                .SetTextAlignment(TextAlignment.CENTER)
                                
                                .SetFontSize(18); 
                                document.Add(title);
                                Image logo = new Image(ImageDataFactory.Create("C:\\POO\\ElectrodomesticosBD\\Presentacion\\Resources\\Logo restaurante marino.png"))
                                .SetWidth(150)
                                .SetHeight(100)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetMarginTop(20);
                                document.Add(logo);
                                document.Add(new Paragraph("\n\n"));
                                Paragraph empresaInfo = new Paragraph("ElectroHouse\nAv. Cabildo 2199\n01139339855\nelectroouse@gmail.com")
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetFontSize(12);
                                document.Add(empresaInfo);
                                document.Add(new Paragraph("\n\n"));
                                document.Add(new Paragraph($"Venta ID: {ventaId}"));
                                document.Add(new Paragraph($"Cliente: {clienteNombre}"));
                                document.Add(new Paragraph($"Fecha: {fechaVenta.ToShortDateString()}"));
                                document.Add(new Paragraph($"Total: ${total}"));
                                document.Add(new Paragraph("\n\n"));
                                Paragraph fechaParagraph = new Paragraph($"Fecha: {fecha}")
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetFontSize(12);
                                

                                Table table = new Table(4);
                                table.SetWidth(UnitValue.CreatePercentValue(100));

                                table.AddHeaderCell(new Cell().Add(new Paragraph("Producto ID")));
                                table.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad")));
                                table.AddHeaderCell(new Cell().Add(new Paragraph("Precio Unitario")));
                                table.AddHeaderCell(new Cell().Add(new Paragraph("Subtotal")));

                                if (detalles == null || !detalles.Any())
                                {
                                    Console.WriteLine("No hay detalles para agregar a la tabla.");
                                }

                                foreach (var detalle in detalles)
                                {
                                    Console.WriteLine($"ProductoID: {detalle.ProductoID}, Cantidad: {detalle.Cantidad}, PrecioUnitario: {detalle.PrecioUnitario}, Subtotal: {detalle.Subtotal}");
                                }

                                foreach (var detalle in detalles)
                                {
                                    if (detalle != null)
                                    {
                                        table.AddCell(detalle.ProductoID.ToString());
                                        table.AddCell(detalle.Cantidad.ToString());
                                        table.AddCell(detalle.PrecioUnitario.ToString("C"));
                                        table.AddCell(detalle.Subtotal.ToString("C"));
                                    }
                                }

                                document.Add(table);
                                document.Add(new Paragraph("\n\n"));
                                document.Add(fechaParagraph);

                                document.Close();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al generar el remito en PDF: " + ex.Message);
            }
        }
        

        public static void ModificarVenta(Venta venta)
        {
            string query = "UPDATE Ventas SET ClienteID = @ClienteID, FechaVenta = @FechaVenta, Total = @Total WHERE VentaID = @VentaID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ClienteID", venta.ClienteID),
            new SqlParameter("@FechaVenta", venta.FechaVenta),
            new SqlParameter("@Total", venta.Total),
            new SqlParameter("@VentaID", venta.VentaID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void EliminarVenta(int VentaID, int usuarioId)
        {
            string query = "DELETE FROM Ventas WHERE VentaID = @VentaID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@VentaID", VentaID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de detalle de venta: DetalleVentaID = {VentaID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId),
            new SqlParameter("@Tabla", "Ventas"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

        public static void ModificarDetalleVenta(DetalleVenta detalleVenta)
        {
            string query = "UPDATE DetalleVenta SET VentaID = @VentaID, ProductoID = @ProductoID, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Subtotal = @Subtotal WHERE DetalleVentaID = @DetalleVentaID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@VentaID", detalleVenta.VentaID),
            new SqlParameter("@ProductoID", detalleVenta.ProductoID),
            new SqlParameter("@Cantidad", detalleVenta.Cantidad),
            new SqlParameter("@PrecioUnitario", detalleVenta.PrecioUnitario),
            new SqlParameter("@Subtotal", detalleVenta.Subtotal),
            new SqlParameter("@DetalleVentaID", detalleVenta.DetalleVentaID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);
        }

        public static void EliminarDetalleVenta(int DetalleVentaID, int usuarioId)
        {
            string query = "DELETE FROM DetalleVenta WHERE DetalleVentaID = @DetalleVentaID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@DetalleVentaID", DetalleVentaID)
            };

            ConexionConBD.ExecuteNonQuery(query, parameters);

            string detalleCambio = $"Eliminación de detalle de venta: DetalleVentaID = {DetalleVentaID}";
            string queryRegistroCambio = "INSERT INTO RegistroCambios (UsuarioID, Tabla, Accion, Fecha, Detalle) " +
                                         "VALUES (@UsuarioID, @Tabla, @Accion, @Fecha, @Detalle)";

            SqlParameter[] registroCambioParams = new SqlParameter[]
            {
            new SqlParameter("@UsuarioID", usuarioId), 
            new SqlParameter("@Tabla", "DetalleVenta"),
            new SqlParameter("@Accion", "Eliminación"),
            new SqlParameter("@Fecha", DateTime.Now),
            new SqlParameter("@Detalle", detalleCambio)
            };

            ConexionConBD.ExecuteNonQuery(queryRegistroCambio, registroCambioParams);
        }

       


        public class StockInsuficienteException : Exception
        {
            public StockInsuficienteException(string message) : base(message)
            {
            }
        }        
    }
}

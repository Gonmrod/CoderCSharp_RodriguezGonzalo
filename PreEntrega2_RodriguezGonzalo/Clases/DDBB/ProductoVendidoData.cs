using Clases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PreEntrega2_RodriguezGonzalo.Clases.DDBB
{
    public class ProductoVendidoData
    {
        private static string connectionString;

        static ProductoVendidoData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
        }

        public static List<ProductoVendido> ObtenerProductoVendido(int idProductoVendido)
        {
            List<ProductoVendido> listProductoVendido = new List<ProductoVendido>();
            var query = @"SELECT
							Id,
							Stock,
							IdProducto,
							IdVenta
						  FROM ProductoVendido WHERE Id = @idProductoVendido;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parameter = new SqlParameter();
                    parameter.ParameterName = "Id";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Value = idProductoVendido;

                    command.Parameters.Add(parameter);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = reader.GetInt32("Id");
                                productoVendido.Stock = reader.GetInt32("Stock");
                                productoVendido.IdProducto = reader.GetInt32("IdProducto");
                                productoVendido.IdVenta = reader.GetInt32("IdVenta");
                                listProductoVendido.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return listProductoVendido;
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> listProductosVendidos = new List<ProductoVendido>();
            var query = @"SELECT
							Id,
							Stock,
							IdProducto,
							IdVenta
						  FROM ProductoVendido;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = reader.GetInt32("Id");
                                productoVendido.Stock = reader.GetInt32("Stock");
                                productoVendido.IdProducto = reader.GetInt32("IdProducto");
                                productoVendido.IdVenta = reader.GetInt32("IdVenta");
                                listProductosVendidos.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return listProductosVendidos;
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            var query = @"INSERT INTO ProductoVendido (Id, Stock, IdProducto, IdVenta)
                          VALUES (@Id, @Stock, @IdProducto, @IdVenta)";

            using (SqlConnection connection = new SqlConnection (connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand (query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                }
                connection.Close();
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            var query = @"UPDATE ProductoVendido
						SET Id	       = @Id,
							Stock      = @Stock,
							IdProducto = @IdProducto,
							IdVenta    = @IdVenta
						WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                }
                connection.Close();
            }
        }

        public static void EliminarProducto(ProductoVendido productoVendido)
        {
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter ("Id", SqlDbType.Int) { Value = productoVendido.Id });
                }
                connection.Close();
            }
        }
    }
}

using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaGestionData
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
                    command.Parameters.Add(new SqlParameter("idProductoVendido", SqlDbType.Int) { Value = idProductoVendido });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdVenta = Convert.ToInt32(reader["IdVenta"])
                                };
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
                                var productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    IdVenta = Convert.ToInt32(reader["IdVenta"])
                                };
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
            var query = @"INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta)
                          VALUES (@Stock, @IdProducto, @IdVenta)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Stock", productoVendido.Stock));
                    command.Parameters.Add(new SqlParameter("@IdProducto", productoVendido.IdProducto));
                    command.Parameters.Add(new SqlParameter("@IdVenta", productoVendido.IdVenta));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo crear el producto vendido.");
                    }
                }
                connection.Close();
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            var query = @"UPDATE ProductoVendido
                          SET Stock = @Stock,
                              IdProducto = @IdProducto,
                              IdVenta = @IdVenta
                          WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", productoVendido.Id));
                    command.Parameters.Add(new SqlParameter("@Stock", productoVendido.Stock));
                    command.Parameters.Add(new SqlParameter("@IdProducto", productoVendido.IdProducto));
                    command.Parameters.Add(new SqlParameter("@IdVenta", productoVendido.IdVenta));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo modificar el producto vendido.");
                    }
                }
                connection.Close();
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", productoVendido.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo eliminar el producto vendido.");
                    }
                }
                connection.Close();
            }
        }
    }
}

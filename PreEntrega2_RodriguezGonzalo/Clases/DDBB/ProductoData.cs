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
    public class ProductoData
    {
        private static string connectionString;

        static ProductoData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
        }
        public static List<Producto> ObtenerProducto(int idProducto)
        {
            List<Producto> listProductos = new List<Producto>();
            var query = @"SELECT
							Id,
							Descripciones,
							Costo,
							PrecioVenta,
							Stock,
							idUsuario
						  FROM Producto WHERE Id = @idProducto;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("idProducto", SqlDbType.Int) { Value = idProducto});

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var producto = new Producto
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Descripcion = reader["Descripciones"].ToString(),
                                    Costo = Convert.ToDouble(reader["Costo"]),
                                    PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                listProductos.Add(producto);
                            }
                        }
                    }
                }
            }
            return listProductos;
        }

        public static List<Producto> ListarProductos()
        {
            List<Producto> listProductos = new List<Producto>();
            var query = @"SELECT
							Id,
							Descripciones,
							Costo,
							PrecioVenta,
							Stock,
							IdUsuario
						  FROM Producto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var producto = new Producto
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Descripcion = reader["Descripciones"].ToString(),
                                    Costo = Convert.ToDouble(reader["Costo"]),
                                    PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                listProductos.Add(producto);
                            }
                        }
                    }
                }
            }
            return listProductos;
        }

        public static void CrearProducto(Producto producto)
        {
            var query = @"INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)
                          VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Descripciones", producto.Descripcion));
                    command.Parameters.Add(new SqlParameter("@Costo", producto.Costo));
                    command.Parameters.Add(new SqlParameter("@PrecioVenta", producto.PrecioVenta));
                    command.Parameters.Add(new SqlParameter("@Stock", producto.Stock));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", producto.IdUsuario));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo crear el producto.");
                    }
                }
                connection.Close();
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            var query = @"UPDATE Producto
                          SET Descripciones = @Descripciones,
                              Costo = @Costo,
                              PrecioVenta = @PrecioVenta,
                              Stock = @Stock,
                              IdUsuario = @IdUsuario
                          WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", producto.Id));
                    command.Parameters.Add(new SqlParameter("@Descripciones", producto.Descripcion));
                    command.Parameters.Add(new SqlParameter("@Costo", producto.Costo));
                    command.Parameters.Add(new SqlParameter("@PrecioVenta", producto.PrecioVenta));
                    command.Parameters.Add(new SqlParameter("@Stock", producto.Stock));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", producto.IdUsuario));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo modificar el producto.");
                    }
                }
                connection.Close();
            }
        }

        public static void EliminarProducto(Producto producto)
        {
            var query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", producto.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo eliminar el producto.");
                    }
                }
                connection.Close();
            }
        }
    }
}

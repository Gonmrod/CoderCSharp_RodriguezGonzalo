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
                    var parameter = new SqlParameter();
                    parameter.ParameterName = "Id";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Value = idProducto;

                    command.Parameters.Add(parameter);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = reader.GetInt32("Id");
                                producto.Descripcion = reader.GetString("Description");
                                producto.Costo = reader.GetDouble("Costo");
                                producto.PrecioVenta = reader.GetDouble("PrecioVenta");
                                producto.Stock = reader.GetInt32("Stock");
                                producto.IdUsuario = reader.GetInt32("IdUsuario");
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
                                var producto = new Producto();
                                producto.Id = reader.GetInt32("Id");
                                producto.Descripcion = reader.GetString("Description");
                                producto.Costo = reader.GetDouble("Costo");
                                producto.PrecioVenta = reader.GetDouble("PrecioVenta");
                                producto.Stock = reader.GetInt32("Stock");
                                producto.IdUsuario = reader.GetInt32("IdUsuario");
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
            var query = @"INSERT INTO Producto (Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario)
                          VALUES (@Id, @Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    command.Parameters.Add(new SqlParameter("Descripcions", SqlDbType.VarChar) { Value = producto.Descripcion });
                    command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Float) { Value = producto.Costo });
                    command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Float) { Value = producto.PrecioVenta });
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Stock });
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.IdUsuario });
                }
                connection.Close();
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            var query = @"UPDATE Producto
						SET Id	          = @Id,
							Descripciones = @Descripciones,
							Costo         = @Costo,
							PrecioVenta   = @PrecioVenta,
							Stock         = @Stock,
							IdUsuario     = @IdUsuario
						WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    command.Parameters.Add(new SqlParameter("Descripcions", SqlDbType.VarChar) { Value = producto.Descripcion });
                    command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Float) { Value = producto.Costo });
                    command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Float) { Value = producto.PrecioVenta });
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Stock });
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.IdUsuario });
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
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                }
                connection.Close();
            }
        }
    }
}

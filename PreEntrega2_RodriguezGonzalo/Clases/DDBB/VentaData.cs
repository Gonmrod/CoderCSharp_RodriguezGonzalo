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
    public class VentaData
    {
        private static string connectionString;

        static VentaData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
        }

        public static List<Venta> ObtenerVenta(int idVenta)
        {
            List<Venta> listVenta = new List<Venta>();
            var query = @"SELECT
							Id,
							Comentarios,
							IdUsuario
						  FROM Venta WHERE Id = @idVenta;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("idVenta", SqlDbType.Int) { Value = idVenta });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var venta = new Venta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Comentarios = reader["Comentarios"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                listVenta.Add(venta);
                            }
                        }
                    }
                }
            }
            return listVenta;
        }

        public static List<Venta> ListarVentas()
        {
            List<Venta> listVentas = new List<Venta>();
            var query = @"SELECT
							Id,
							Comentarios,
							IdUsuario
						  FROM Venta;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                var venta = new Venta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Comentarios = reader["Comentarios"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                listVentas.Add(venta);
                            }
                        }
                    }
                }
            }
            return listVentas;
        }

        public static void CrearVenta(Venta venta)
        {
            var query = @"INSERT INTO Venta (Id, Comentarios, IdUsuario)
                          VALUES (@Id, @Comentarios, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    cmd.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    cmd.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                }
                connection.Close();
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            var query = @"UPDATE Venta
						SET Id	       = @Id,
							Comentario = @Comentario,
							IdUsuario  = @IdUsuario
						WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                }
                connection.Close();
            }
        }

        public static void EliminarVenta(Venta venta)
        {
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                }
                connection.Close();
            }
        }
    }
}

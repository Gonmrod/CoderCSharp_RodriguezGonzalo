using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace PreEntrega2_RodriguezGonzalo.Clases.DDBB
{
	public class UsuarioData
	{
		public static List<Usuario> ObtenerUsuario(int idUsuario)
		{
			List<Usuario> listUsuario = new List<Usuario>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            var query = @"SELECT
							Id,
							Nombre,
							Apellido,
							NombreUsuario,
							Contraseña,
							Mail
						  FROM Usuario WHERE Id = @idUsuario;";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					var parameter = new SqlParameter();
					parameter.ParameterName = "Id";
					parameter.SqlDbType = SqlDbType.Int;
					parameter.Value = idUsuario;

					command.Parameters.Add(parameter);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.HasRows)
						{
							while (reader.Read())
							{
								var usuario = new Usuario();
								usuario.Id = Convert.ToInt32(reader["Id"]);
								usuario.Nombre = reader["Nombre"].ToString();
								usuario.Apellido = reader["Apellido"].ToString();
								usuario.NombreUsuario = reader["NombreUsuario"].ToString();
								usuario.Contrasenia = reader["Contraseña"].ToString();
								usuario.Mail = reader["Mail"].ToString();
								listUsuario.Add(usuario);
							}
						}
					}

				}


			}
			return listUsuario;
		}

		public static List<Usuario> ListarUsuarios()
		{
			List<Usuario> listUsuarios = new List<Usuario>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            var query = @"SELECT
							Id,
							Nombre,
							Apellido,
							NombreUsuario,
							Contraseña,
							Mail
						  FROM Usuario";

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
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = reader["Nombre"].ToString();
                                usuario.Apellido = reader["Apellido"].ToString();
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Contrasenia = reader["Contraseña"].ToString();
                                usuario.Mail = reader["Mail"].ToString();
                                listUsuarios.Add(usuario);
                            }
						}
					}
				}
			}
			return listUsuarios;
        }

		public static void CrearUsuario(Usuario usuario)
		{
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            var query = @"INSERT INTO Usuario (Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail)
						  VALUES (@Id, @Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
					command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
					command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
					command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
					command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
					command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
				}
				connection.Close();
			}
        }

		public static void ModificarUsuario(Usuario usuario)
		{
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            var query = @"UPDATE Usuario
						SET Id	          = @Id,
							Nombre        = @Nombre,
							Apellido      = @Apellido,
							NombreUsuario = @NombreUsuario,
							Contraseña    = @Contraseña,
							Mail		  = @Mail
						WHERE Id = @Id";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                    command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                }
				connection.Close();
			}
        }
		
		public static void EliminarUsuario(Usuario usuario)
		{
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
			var query = "DELETE FROM Usuario WHERE Id = @Id";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
				}
				connection.Close();
			}
        }
	}

}

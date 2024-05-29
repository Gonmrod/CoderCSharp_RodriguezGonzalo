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
                    command.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int) { Value = idUsuario });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var usuario = new Usuario
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    Contrasenia = reader["Contraseña"].ToString(),
                                    Mail = reader["Mail"].ToString()
                                };
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
            var query = @"INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)
                          VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                    command.Parameters.Add(new SqlParameter("@Apellido", usuario.Apellido));
                    command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contrasenia));
                    command.Parameters.Add(new SqlParameter("@Mail", usuario.Mail));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo crear el usuario.");
                    }
                }
                connection.Close();
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            var query = @"UPDATE Usuario
                          SET Nombre = @Nombre,
                              Apellido = @Apellido,
                              NombreUsuario = @NombreUsuario,
                              Contraseña = @Contraseña,
                              Mail = @Mail
                          WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", usuario.Id));
                    command.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                    command.Parameters.Add(new SqlParameter("@Apellido", usuario.Apellido));
                    command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contrasenia));
                    command.Parameters.Add(new SqlParameter("@Mail", usuario.Mail));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo modificar el usuario.");
                    }
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
                    command.Parameters.Add(new SqlParameter("@Id", usuario.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo eliminar el usuario.");
                    }
                }
                connection.Close();
            }
        }
    }

}

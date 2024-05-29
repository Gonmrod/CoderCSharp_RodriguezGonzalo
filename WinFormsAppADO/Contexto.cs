using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WinFormsAppADO
{
    public static class Contexto
    {
        public static List<Usuario> DevolverUsuarios()
        {
            var listaUsuarios = new List<Usuario>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["ID"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();

                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            return listaUsuarios;
        }
    }
}

using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> ObtenerUsuario(int idUsuario)
        {
            try
            {
                return UsuarioData.ObtenerUsuario(idUsuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public static List<Usuario> ListarUsuarios()
        {
            try
            {
                return UsuarioData.ListarUsuarios();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar los usuarios", ex);
            }
        }

        public static void CrearUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear el usuario", ex);
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar el usuario", ex);
            }
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.EliminarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar el usuario", ex);
            }
            
        }
    }
}

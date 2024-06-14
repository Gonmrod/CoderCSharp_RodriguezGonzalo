using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace APIConsumerSistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUser")]
        public IEnumerable<Usuario> usuario()
        {
            return UsuarioBussiness.ListarUsuarios().ToArray();
        }

        [HttpGet("GetUserById/{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            List<Usuario> usuario = UsuarioBussiness.ObtenerUsuario(id);

            return Ok(usuario);
        }

        [HttpPost("CreateUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }

        [HttpPut("UpdateUser")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

        [HttpDelete("DeleteUser")]
        public void Delete([FromBody] Usuario usuario)
        {
            UsuarioBussiness.EliminarUsuario(usuario);
        }
    }
}

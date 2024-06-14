using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace APIConsumerSistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IEnumerable<Producto> GetProductos()
        {
            return ProductoBussiness.ListarProductos().ToArray();
        }

        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProducto(int id) 
        { 
            return Ok(ProductoBussiness.ObtenerProducto(id));
        }

        [HttpPost("CreateProduct")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }

        [HttpPut("UpdateProduct")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        [HttpDelete("DeleteProduct")]
        public void Delete([FromBody] Producto producto)
        {
            ProductoBussiness.EliminarProducto(producto);
        }
    }
}

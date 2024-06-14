using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace APIConsumerSistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("GetSoldProducts")]
        public IEnumerable<ProductoVendido> GetSoldProducts()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos();
        }

        [HttpGet("GetSoldProduct/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(ProductoVendidoBussiness.ObtenerProductoVendido(id));
        }

        [HttpPost("CreateProduct")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }

        [HttpPut("UpdateProduct")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

        [HttpDelete("DeleteProduct")]
        public void Delete([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(productoVendido);
        }
    }
}

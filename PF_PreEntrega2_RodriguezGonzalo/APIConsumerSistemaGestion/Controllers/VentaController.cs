using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace APIConsumerSistemaGestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet("GetSales")]
        public IEnumerable<Venta> GetSales()
        {
            return VentaBussiness.ListarVentas();
        }

        [HttpGet("GetSaleById/{id}")]
        public IActionResult GetSaleById(int id)
        { 
            return Ok(VentaBussiness.ObtenerVenta(id));
        }

        [HttpPost("CreateSale")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }

        [HttpPut("UpdateSale")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVenta(venta);
        }

        [HttpDelete("DeleteSale")]
        public void Delete([FromBody] Venta venta)
        {
            VentaBussiness.EliminarVenta(venta);
        }
    }
}

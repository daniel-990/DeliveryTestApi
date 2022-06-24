using DeliveryTestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private DeliveryContext _context;

        public ProductoController()
        {
            _context = new DeliveryContext();
        }
        // GET: api/<ProductoController>
        [HttpGet("{id}")]
        public ActionResult<List<Producto>> Get(int id)
        {
            var producto = _context.Producto.FirstOrDefault(x => x.IdProducto == id);
            if (producto is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(producto);
            }
        }

    }
}

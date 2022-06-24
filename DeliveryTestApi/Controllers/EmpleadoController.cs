using DeliveryTestApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private DeliveryContext _context;

        public EmpleadoController()
        {
            _context = new DeliveryContext();
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult<List<Empleado>> Get()
        {
            var listadoEmpl = _context.Empleados;
            return Ok(listadoEmpl);
        }

    }
}

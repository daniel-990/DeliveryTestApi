using DeliveryTestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

        [HttpGet]
        public ActionResult<List<Empleado>> Get()
        {
            var listadoEmpl = _context.Empleado;
            return Ok(listadoEmpl);
        }
    }
}

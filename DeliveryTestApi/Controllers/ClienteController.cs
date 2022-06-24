using DeliveryTestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private DeliveryContext _context;

        public ClienteController()
        {
            _context = new DeliveryContext();
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            var listado = _context.Clientes;
            return Ok(listado);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Cliente>> Get(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(x => x.ClienteId == id);
            if(cliente is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cliente);
            }
        }
        [HttpPost]
        public ActionResult Post(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ClienteA = _context.Clientes.FirstOrDefault(x => x.ClienteId == id);
            _context.Clientes.Remove(ClienteA);
            _context.SaveChanges();
            return Ok(ClienteA);
        }

    }
}

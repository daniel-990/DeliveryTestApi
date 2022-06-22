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
        // GET: api/<ClienteController>
        [HttpGet]
        //para documentar los end points con el swagger
        /// <summary>
        /// Permite consultar la informacion de un cliente, nombre, correo etc..
        /// 
        /// </summary>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Cliente>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        public ActionResult<List<Cliente>> Get()
        {
            var listado = _context.Cliente;
            return Ok(listado);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Cliente>> Get(int id)
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.ClienteId == id);
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
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ClienteA = _context.Cliente.FirstOrDefault(x => x.ClienteId == id);
            _context.Cliente.Remove(ClienteA );
            _context.SaveChanges();
        }
/*        public ActionResult<List<Cliente>> Delete(int id)
        {
            var cliente = _context.Cliente.FirstOrDefault(x => x.ClienteId == id);
            _context.SaveChanges();
            return Ok();
        }*/

    }
}

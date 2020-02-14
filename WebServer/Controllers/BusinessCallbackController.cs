using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessCallbackController : ControllerBase
    {
        private readonly Context _context;

        public BusinessCallbackController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/businesscallback
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<BusinessCallback>>> GetBusinessCallbackAllItems()
        {
            return await _context.BusinessCallback.ToListAsync();
        }

        // GET Page: api/businesscallback/FIRSTNAME/LASTNAME/EMAIL
        [HttpGet("{fname}/{lname}/{email}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<BusinessCallback>>> GetBusinessCallbackItems(string fname, string lname, string email)
        {
            return await _context.BusinessCallback.Where(i => i.FirstName == fname && i.LastName == lname && i.Email == email).ToListAsync();
        }

        // POST/ADD: api/BusinessCallback
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<BusinessCallback>> PostBusinessCallbackItem(BusinessCallback item)
        {
            _context.BusinessCallback.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBusinessCallbackAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/BusinessCallback
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> PutBusinessCallbackItem(int id, BusinessCallback item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/BusinessCallback
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteBusinessCallbackItem(int id)
        {
            var businessItem = await _context.BusinessCallback.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.BusinessCallback.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

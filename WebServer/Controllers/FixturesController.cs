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
    public class FixturesController : ControllerBase
    {
        private readonly Context _context;

        public FixturesController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Fixtures
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Fixtures>>> GetFixturesAllItems()
        {
            return await _context.Fixtures.ToListAsync();
        }


        // POST/ADD: api/Fixtures
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<Fixtures>> PostFixturesItem(Fixtures item)
        {
            _context.Fixtures.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFixturesAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/Fixtures
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> PutFixturesItem(int id, Fixtures item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Fixtures
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteFixturesItem(int id)
        {
            var businessItem = await _context.Fixtures.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.Fixtures.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

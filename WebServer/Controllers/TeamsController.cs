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
    public class TeamsController : ControllerBase
    {
        private readonly Context _context;

        public TeamsController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Teams
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Teams>>> GetTeamsAllItems()
        {
            return await _context.Teams.ToListAsync();
        }


        // POST/ADD: api/Teams
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<Teams>> PostTeamsItem(Teams item)
        {
            _context.Teams.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTeamsAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/Teams
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")] 
        public async Task<IActionResult> PutTeamsItem(int id, Teams item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Teams
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteTeamsItem(int id)
        {
            var businessItem = await _context.Teams.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

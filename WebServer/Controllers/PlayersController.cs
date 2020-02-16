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
    public class PlayersController : ControllerBase
    {
        private readonly Context _context;

        public PlayersController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Teams
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Players>>> GetPlayersAllItems()
        {
            return await _context.Players.ToListAsync();
        }


        // POST/ADD: api/Teams
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<Players>> PostPlayersItem(Players item)
        {
            _context.Players.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayersAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/Teams
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")] 
        public async Task<IActionResult> PutPlayersItem(int id, Players item)
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
        public async Task<IActionResult> DeletePlayersItem(int id)
        {
            var businessItem = await _context.Players.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.Players.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

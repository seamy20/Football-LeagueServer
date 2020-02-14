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
    public class TeamController : ControllerBase
    {
        private readonly Context _context;

        public TeamController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/LeagueModel
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<LeagueModel>>> GetLeagueModelAllItems()
        {
            return await _context.LeagueModel.ToListAsync();
        }


        // POST/ADD: api/LeagueModel
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<LeagueModel>> PostLeagueModelItem(LeagueModel item)
        {
            _context.LeagueModel.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLeagueModelAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/LeagueModel
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")] 
        public async Task<IActionResult> PutLeagueModelItem(int id, LeagueModel item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/LeagueModel
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteLeagueModelItem(int id)
        {
            var businessItem = await _context.LeagueModel.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.LeagueModel.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

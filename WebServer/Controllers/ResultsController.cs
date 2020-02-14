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
    public class ResultsController : ControllerBase
    {
        private readonly Context _context;

        public ResultsController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Results
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Results>>> GetResultsAllItems()
        {
            return await _context.Results.ToListAsync();
        }


        // POST/ADD: api/Results
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<Results>> PostResultsItem(Results item)
        {
            _context.Results.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetResultsAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/Results
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")] 
        public async Task<IActionResult> PutResultsItem(int id, Results item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Results
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteResultsItem(int id)
        {
            var businessItem = await _context.Results.FindAsync(id);

            if (businessItem == null)
            {
                return NotFound();
            }

            _context.Results.Remove(businessItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

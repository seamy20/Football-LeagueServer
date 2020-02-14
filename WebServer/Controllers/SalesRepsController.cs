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
    public class SalesRepsController : ControllerBase
    {
        private readonly Context _context;

        public SalesRepsController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/SalesReps 
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<SalesReps>>> GetAllSalesReps()
        {
            return await _context.SalesReps.ToListAsync();
        }

        // GET Page: api/Complaint/id/pin
        [HttpGet("{userID}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<SalesReps>>> GetSalesRepsByID(int userID)
        {
            return await _context.SalesReps.Where(i => i.Id == userID).ToListAsync();
        }

        // GET Page: api/pagecontent/PAGE/JURISDICTION
        [HttpGet("{jurisdiction}/{budgetID}/{password}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<SalesReps>>> GetPageContentByPage(string jurisdiction, string budgetID, string password)
        {
            return await _context.SalesReps.Where(i => i.jurisdiction == jurisdiction && i.budgetID == budgetID && i.password == password).ToListAsync();
        }

        // PUT/UPDATE: api/pagecontent
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> PutPageSalesRepsItem(int id, SalesReps item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST/ADD: api/pagecontent
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<SalesReps>> PostSalesRep(SalesReps item)
        {
            _context.SalesReps.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllSalesReps), new { id = item.Id }, item);
        }
    }
}


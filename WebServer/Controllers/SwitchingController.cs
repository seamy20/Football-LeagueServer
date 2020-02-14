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
    public class SwitchingController : ControllerBase
    {
        private readonly Context _context;

        public SwitchingController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/User 
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Switching>>> GetAllSwitchedUsers()
        {
            return await _context.Switching.ToListAsync();
        }

        // GET Page: api/Complaint/id/pin
        [HttpGet("{userID}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Switching>>> GetSwitchedUsersByID(int joinID)
        {
            return await _context.Switching.Where(i => i.Id == joinID).ToListAsync();
        }

        // POST/ADD: api/pagecontent
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<Switching>> PostUser(Switching item)
        {
            _context.Switching.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllSwitchedUsers), new { id = item.Id }, item);
        }
    }
}


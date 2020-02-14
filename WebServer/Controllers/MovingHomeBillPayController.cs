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
    public class MovingHomeBillPayController : ControllerBase
    {
        private readonly Context _context;

        public MovingHomeBillPayController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/User 
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<MovingHomeBillPay>>> GetAllHomeMoves()
        {
            return await _context.MovingHomeBillPay.ToListAsync();
        }

        // GET Page: api/Complaint/id/pin
        [HttpGet("{userID}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<MovingHomeBillPay>>> GetHomeMoveID(int homeMoveID)
        {
            return await _context.MovingHomeBillPay.Where(i => i.Id == homeMoveID).ToListAsync();
        }

        // POST/ADD: api/pagecontent
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<MovingHomeBillPay>> PostHomeMove(MovingHomeBillPay item)
        {
            _context.MovingHomeBillPay.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllHomeMoves), new { id = item.Id }, item);
        }
    }
}


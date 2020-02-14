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
    public class ComplaintsController : ControllerBase
    {
        private readonly Context _context;

        public ComplaintsController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Complaint 
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Complaints>>> GetAllComplaint()
        {
            return await _context.Complaints.ToListAsync();
        }

        // GET Page: api/Complaint/id/pin
        [HttpGet("{complaintID}/{PIN}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<Complaints>>> GetComplaintByIDAndPin(string complaintID, string PIN)
        {
            return await _context.Complaints.Where(i => i.ComplaintID == complaintID && i.PIN == PIN).ToListAsync();
        }
    }
}

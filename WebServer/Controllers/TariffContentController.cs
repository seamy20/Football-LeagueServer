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
    public class TariffContentController : ControllerBase
    {
        private readonly Context _context;

        public TariffContentController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/Tariffcontent
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<TariffContent>>> GetTariffContentAllItems()
        {
            return await _context.TariffContents.ToListAsync();
        }

        // GET Tariff: api/Tariffcontent/Tariff/JURISDICTION
        [HttpGet("{Tariff}/{jurisdiction}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<TariffContent>>> GetTariffContentByTariff(string jurisdiction, string Tariff)
        {
            return await _context.TariffContents.Where(i => i.Tariff == Tariff && i.Jurisdiction == jurisdiction).ToListAsync();
        }

        // POST/ADD: api/Tariffcontent
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<TariffContent>> PostTariffContentItem(TariffContent item)
        {
            _context.TariffContents.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTariffContentAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/Tariffcontent
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> PutTariffContentItem(int id, TariffContent item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Tariffcontent
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeleteTariffContentItem(int id)
        {
            var TariffItem = await _context.TariffContents.FindAsync(id);

            if (TariffItem == null)
            {
                return NotFound();
            }

            _context.TariffContents.Remove(TariffItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

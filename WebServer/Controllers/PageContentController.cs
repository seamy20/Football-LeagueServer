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
    public class PageContentController : ControllerBase
    {
        private readonly Context _context;

        public PageContentController(Context context)
        {
            _context = context;
        }

        // GET ALL: api/pagecontent
        [HttpGet]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<PageContent>>> GetPageContentAllItems()
        {
            return await _context.PageContents.ToListAsync();
        }

        // GET Page: api/pagecontent/PAGE/JURISDICTION
        [HttpGet("{page}/{jurisdiction}")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<IEnumerable<PageContent>>> GetPageContentByPage(string jurisdiction, string page)
        {
            return await _context.PageContents.Where(i => i.Page == page && i.Jurisdiction == jurisdiction).ToListAsync();
        }

        // POST/ADD: api/pagecontent
        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<PageContent>> PostPageContentItem(PageContent item)
        {
            _context.PageContents.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPageContentAllItems), new { id = item.Id }, item);
        }

        // PUT/UPDATE: api/pagecontent
        [HttpPut("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> PutPageContentItem(int id, PageContent item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/pagecontent
        [HttpDelete("{id}")]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> DeletePageContentItem(int id)
        {
            var pageItem = await _context.PageContents.FindAsync(id);

            if (pageItem == null)
            {
                return NotFound();
            }

            _context.PageContents.Remove(pageItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

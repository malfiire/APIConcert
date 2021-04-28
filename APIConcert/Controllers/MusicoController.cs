using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlPanelConcerts.ContextDb;
using ControlPanelConcerts.Models;

namespace APIConcert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicoController : ControllerBase
    {
        private readonly MyContext _context;

        public MusicoController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Musico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Musico>>> GetMusico()
        {
            return await _context.Musico.ToListAsync();
        }

        // GET: api/Musico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Musico>> GetMusico(int id)
        {
            var musico = await _context.Musico.FindAsync(id);

            if (musico == null)
            {
                return NotFound();
            }

            return musico;
        }

        // PUT: api/Musico/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusico(int id, Musico musico)
        {
            if (id != musico.Id)
            {
                return BadRequest();
            }

            _context.Entry(musico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Musico
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Musico>> PostMusico(Musico musico)
        {
            _context.Musico.Add(musico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMusico", new { id = musico.Id }, musico);
        }

        // DELETE: api/Musico/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusico(int id)
        {
            var musico = await _context.Musico.FindAsync(id);
            if (musico == null)
            {
                return NotFound();
            }

            _context.Musico.Remove(musico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicoExists(int id)
        {
            return _context.Musico.Any(e => e.Id == id);
        }
    }
}

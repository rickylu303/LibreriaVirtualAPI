using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibreriaVirtualWebApi.Models;

namespace LibreriaVirtualWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialsController : ControllerBase
    {
        private readonly AllContext _context;

        public EditorialsController(AllContext context)
        {
            _context = context;
        }

        // GET: api/Editorials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editorials>>> GetEditorials()
        {
          if (_context.Editorials == null)
          {
              return NotFound();
          }
            return await _context.Editorials.ToListAsync();
        }

        // GET: api/Editorials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Editorials>> GetEditorials(int id)
        {
          if (_context.Editorials == null)
          {
              return NotFound();
          }
            var editorials = await _context.Editorials.FindAsync(id);

            if (editorials == null)
            {
                return NotFound();
            }

            return editorials;
        }

        // PUT: api/Editorials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEditorials(int id, Editorials editorials)
        {
            if (id != editorials.id_editorial)
            {
                return BadRequest();
            }

            _context.Entry(editorials).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditorialsExists(id))
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

        // POST: api/Editorials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Editorials>> PostEditorials(Editorials editorials)
        {
          if (_context.Editorials == null)
          {
              return Problem("Entity set 'AllContext.Editorials'  is null.");
          }
            _context.Editorials.Add(editorials);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEditorials", new { id = editorials.id_editorial }, editorials);
        }

        // DELETE: api/Editorials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEditorials(int id)
        {
            if (_context.Editorials == null)
            {
                return NotFound();
            }
            var editorials = await _context.Editorials.FindAsync(id);
            if (editorials == null)
            {
                return NotFound();
            }

            _context.Editorials.Remove(editorials);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EditorialsExists(int id)
        {
            return (_context.Editorials?.Any(e => e.id_editorial == id)).GetValueOrDefault();
        }
    }
}

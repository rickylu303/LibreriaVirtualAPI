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
    public class Authors1Controller : ControllerBase
    {
        private readonly AllContext _context;

        public Authors1Controller(AllContext context)
        {
            _context = context;
        }

        // GET: api/Authors1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Authors>>> GetAutores()
        {
          if (_context.Autores == null)
          {
              return NotFound();
          }
            return await _context.Autores.ToListAsync();
        }

        // GET: api/Authors1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Authors>> GetAuthors(int id)
        {
          if (_context.Autores == null)
          {
              return NotFound();
          }
            var authors = await _context.Autores.FindAsync(id);

            if (authors == null)
            {
                return NotFound();
            }

            return authors;
        }

        // PUT: api/Authors1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthors(int id, Authors authors)
        {
            if (id != authors.id_autor)
            {
                return BadRequest();
            }

            _context.Entry(authors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorsExists(id))
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

        // POST: api/Authors1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Authors>> PostAuthors(Authors authors)
        {
          if (_context.Autores == null)
          {
              return Problem("Entity set 'AllContext.Autores'  is null.");
          }
            _context.Autores.Add(authors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthors", new { id = authors.id_autor }, authors);
        }

        // DELETE: api/Authors1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthors(int id)
        {
            if (_context.Autores == null)
            {
                return NotFound();
            }
            var authors = await _context.Autores.FindAsync(id);
            if (authors == null)
            {
                return NotFound();
            }

            _context.Autores.Remove(authors);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthorsExists(int id)
        {
            return (_context.Autores?.Any(e => e.id_autor == id)).GetValueOrDefault();
        }
    }
}

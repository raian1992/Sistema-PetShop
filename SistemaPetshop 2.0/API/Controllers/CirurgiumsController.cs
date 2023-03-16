using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CirurgiumsController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public CirurgiumsController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Cirurgiums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cirurgium>>> GetCirurgia()
        {
            return await _context.Cirurgia.ToListAsync();
        }

        // GET: api/Cirurgiums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cirurgium>> GetCirurgium(int id)
        {
            var cirurgium = await _context.Cirurgia.FindAsync(id);

            if (cirurgium == null)
            {
                return NotFound();
            }

            return cirurgium;
        }

        // PUT: api/Cirurgiums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCirurgium(int id, Cirurgium cirurgium)
        {
            if (id != cirurgium.IdCirurgia)
            {
                return BadRequest();
            }

            _context.Entry(cirurgium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CirurgiumExists(id))
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

        // POST: api/Cirurgiums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cirurgium>> PostCirurgium(Cirurgium cirurgium)
        {
            _context.Cirurgia.Add(cirurgium);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCirurgium", new { id = cirurgium.IdCirurgia }, cirurgium);
        }

        // DELETE: api/Cirurgiums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCirurgium(int id)
        {
            var cirurgium = await _context.Cirurgia.FindAsync(id);
            if (cirurgium == null)
            {
                return NotFound();
            }

            _context.Cirurgia.Remove(cirurgium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CirurgiumExists(int id)
        {
            return _context.Cirurgia.Any(e => e.IdCirurgia == id);
        }
    }
}

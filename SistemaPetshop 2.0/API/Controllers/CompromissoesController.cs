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
    public class CompromissoesController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public CompromissoesController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Compromissoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compromisso>>> GetCompromissos()
        {
            return await _context.Compromissos.ToListAsync();
        }

        // GET: api/Compromissoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compromisso>> GetCompromisso(int id)
        {
            var compromisso = await _context.Compromissos.FindAsync(id);

            if (compromisso == null)
            {
                return NotFound();
            }

            return compromisso;
        }

        // PUT: api/Compromissoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompromisso(int id, Compromisso compromisso)
        {
            if (id != compromisso.Id)
            {
                return BadRequest();
            }

            _context.Entry(compromisso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompromissoExists(id))
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

        // POST: api/Compromissoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compromisso>> PostCompromisso(Compromisso compromisso)
        {
            _context.Compromissos.Add(compromisso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompromisso", new { id = compromisso.Id }, compromisso);
        }

        // DELETE: api/Compromissoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompromisso(int id)
        {
            var compromisso = await _context.Compromissos.FindAsync(id);
            if (compromisso == null)
            {
                return NotFound();
            }

            _context.Compromissos.Remove(compromisso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompromissoExists(int id)
        {
            return _context.Compromissos.Any(e => e.Id == id);
        }
    }
}

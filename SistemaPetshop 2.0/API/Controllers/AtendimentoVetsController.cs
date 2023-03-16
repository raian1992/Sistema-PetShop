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
    public class AtendimentoVetsController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public AtendimentoVetsController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/AtendimentoVets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AtendimentoVet>>> GetAtendimentoVets()
        {
            return await _context.AtendimentoVets.ToListAsync();
        }

        // GET: api/AtendimentoVets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AtendimentoVet>> GetAtendimentoVet(int id)
        {
            var atendimentoVet = await _context.AtendimentoVets.FindAsync(id);

            if (atendimentoVet == null)
            {
                return NotFound();
            }

            return atendimentoVet;
        }

        // PUT: api/AtendimentoVets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtendimentoVet(int id, AtendimentoVet atendimentoVet)
        {
            if (id != atendimentoVet.IdAtendimento)
            {
                return BadRequest();
            }

            _context.Entry(atendimentoVet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtendimentoVetExists(id))
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

        // POST: api/AtendimentoVets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AtendimentoVet>> PostAtendimentoVet(AtendimentoVet atendimentoVet)
        {
            _context.AtendimentoVets.Add(atendimentoVet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAtendimentoVet", new { id = atendimentoVet.IdAtendimento }, atendimentoVet);
        }

        // DELETE: api/AtendimentoVets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtendimentoVet(int id)
        {
            var atendimentoVet = await _context.AtendimentoVets.FindAsync(id);
            if (atendimentoVet == null)
            {
                return NotFound();
            }

            _context.AtendimentoVets.Remove(atendimentoVet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AtendimentoVetExists(int id)
        {
            return _context.AtendimentoVets.Any(e => e.IdAtendimento == id);
        }
    }
}

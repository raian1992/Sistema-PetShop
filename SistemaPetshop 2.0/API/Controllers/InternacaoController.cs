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
    public class InternacaoController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public InternacaoController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Internacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Internacao>>> GetInternacaos()
        {
            return await _context.Internacaos.ToListAsync();
        }

        // GET: api/Internacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Internacao>> GetInternacao(int id)
        {
            var internacao = await _context.Internacaos.FindAsync(id);

            if (internacao == null)
            {
                return NotFound();
            }

            return internacao;
        }

        // PUT: api/Internacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInternacao(int id, Internacao internacao)
        {
            if (id != internacao.IdInternacao)
            {
                return BadRequest();
            }

            _context.Entry(internacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternacaoExists(id))
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

        // POST: api/Internacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Internacao>> PostInternacao(Internacao internacao)
        {
            _context.Internacaos.Add(internacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInternacao", new { id = internacao.IdInternacao }, internacao);
        }

        // DELETE: api/Internacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInternacao(int id)
        {
            var internacao = await _context.Internacaos.FindAsync(id);
            if (internacao == null)
            {
                return NotFound();
            }

            _context.Internacaos.Remove(internacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InternacaoExists(int id)
        {
            return _context.Internacaos.Any(e => e.IdInternacao == id);
        }
    }
}

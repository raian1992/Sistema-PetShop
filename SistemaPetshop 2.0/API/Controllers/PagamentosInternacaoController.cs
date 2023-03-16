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
    public class PagamentosInternacaoController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public PagamentosInternacaoController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/PagamentosInternacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagamentosInternacao>>> GetPagamentosInternacaos()
        {
            return await _context.PagamentosInternacaos.ToListAsync();
        }

        // GET: api/PagamentosInternacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PagamentosInternacao>> GetPagamentosInternacao(int id)
        {
            var pagamentosInternacao = await _context.PagamentosInternacaos.FindAsync(id);

            if (pagamentosInternacao == null)
            {
                return NotFound();
            }

            return pagamentosInternacao;
        }

        // PUT: api/PagamentosInternacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPagamentosInternacao(int id, PagamentosInternacao pagamentosInternacao)
        {
            if (id != pagamentosInternacao.IdAssociacao)
            {
                return BadRequest();
            }

            _context.Entry(pagamentosInternacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagamentosInternacaoExists(id))
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

        // POST: api/PagamentosInternacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PagamentosInternacao>> PostPagamentosInternacao(PagamentosInternacao pagamentosInternacao)
        {
            _context.PagamentosInternacaos.Add(pagamentosInternacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPagamentosInternacao", new { id = pagamentosInternacao.IdAssociacao }, pagamentosInternacao);
        }

        // DELETE: api/PagamentosInternacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePagamentosInternacao(int id)
        {
            var pagamentosInternacao = await _context.PagamentosInternacaos.FindAsync(id);
            if (pagamentosInternacao == null)
            {
                return NotFound();
            }

            _context.PagamentosInternacaos.Remove(pagamentosInternacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PagamentosInternacaoExists(int id)
        {
            return _context.PagamentosInternacaos.Any(e => e.IdAssociacao == id);
        }
    }
}

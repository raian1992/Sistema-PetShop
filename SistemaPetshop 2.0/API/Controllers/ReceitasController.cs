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
    public class ReceitasController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public ReceitasController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Receitas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receitum>>> GetReceita()
        {
            return await _context.Receita.ToListAsync();
        }

        // GET: api/Receitas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receitum>> GetReceitum(int id)
        {
            var receitum = await _context.Receita.FindAsync(id);

            if (receitum == null)
            {
                return NotFound();
            }

            return receitum;
        }

        // PUT: api/Receitas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceitum(int id, Receitum receitum)
        {
            if (id != receitum.IdReceita)
            {
                return BadRequest();
            }

            _context.Entry(receitum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceitumExists(id))
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

        // POST: api/Receitas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Receitum>> PostReceitum(Receitum receitum)
        {
            _context.Receita.Add(receitum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReceitum", new { id = receitum.IdReceita }, receitum);
        }

        // DELETE: api/Receitas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceitum(int id)
        {
            var receitum = await _context.Receita.FindAsync(id);
            if (receitum == null)
            {
                return NotFound();
            }

            _context.Receita.Remove(receitum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReceitumExists(int id)
        {
            return _context.Receita.Any(e => e.IdReceita == id);
        }
    }
}

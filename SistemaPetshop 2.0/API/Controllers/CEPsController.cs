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
    public class CepsController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public CepsController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Ceps
        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<Cep>>> GetCeps()
        {
            return await _context.Ceps.ToListAsync();
        }

        // GET: api/Ceps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cep>> GetCep(int id)
        {
            var cep = await _context.Ceps.FindAsync(id);

            if (cep == null)
            {
                return NotFound();
            }

            return cep;
        }

        // PUT: api/Ceps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCep(int id, Cep cep)
        {
            if (id != cep.IdCep)
            {
                return BadRequest();
            }

            _context.Entry(cep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CepExists(id))
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

        // POST: api/Ceps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cep>> PostCep(Cep cep)
        {
            _context.Ceps.Add(cep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCep", new { id = cep.IdCep }, cep);
        }

        // DELETE: api/Ceps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCep(int id)
        {
            var cep = await _context.Ceps.FindAsync(id);
            if (cep == null)
            {
                return NotFound();
            }

            _context.Ceps.Remove(cep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CepExists(int id)
        {
            return _context.Ceps.Any(e => e.IdCep == id);
        }
    }
}

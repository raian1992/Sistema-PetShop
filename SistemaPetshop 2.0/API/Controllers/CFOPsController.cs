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
    public class CfopsController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public CfopsController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Cfops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cfop>>> GetCfops()
        {
            return await _context.Cfops.ToListAsync();
        }

        // GET: api/Cfops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cfop>> GetCfop(int id)
        {
            var cfop = await _context.Cfops.FindAsync(id);

            if (cfop == null)
            {
                return NotFound();
            }

            return cfop;
        }

        // PUT: api/Cfops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCfop(int id, Cfop cfop)
        {
            if (id != cfop.IdCfop)
            {
                return BadRequest();
            }

            _context.Entry(cfop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CfopExists(id))
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

        // POST: api/Cfops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cfop>> PostCfop(Cfop cfop)
        {
            _context.Cfops.Add(cfop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCfop", new { id = cfop.IdCfop }, cfop);
        }

        // DELETE: api/Cfops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCfop(int id)
        {
            var cfop = await _context.Cfops.FindAsync(id);
            if (cfop == null)
            {
                return NotFound();
            }

            _context.Cfops.Remove(cfop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CfopExists(int id)
        {
            return _context.Cfops.Any(e => e.IdCfop == id);
        }
    }
}

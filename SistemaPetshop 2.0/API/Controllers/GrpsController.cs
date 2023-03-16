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
    public class GrpsController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public GrpsController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Grps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grp>>> GetGrps()
        {
            return await _context.Grps.ToListAsync();
        }

        // GET: api/Grps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grp>> GetGrp(int id)
        {
            var grp = await _context.Grps.FindAsync(id);

            if (grp == null)
            {
                return NotFound();
            }

            return grp;
        }

        // PUT: api/Grps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrp(int id, Grp grp)
        {
            if (id != grp.CodGrp)
            {
                return BadRequest();
            }

            _context.Entry(grp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrpExists(id))
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

        // POST: api/Grps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grp>> PostGrp(Grp grp)
        {
            _context.Grps.Add(grp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrp", new { id = grp.CodGrp }, grp);
        }

        // DELETE: api/Grps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrp(int id)
        {
            var grp = await _context.Grps.FindAsync(id);
            if (grp == null)
            {
                return NotFound();
            }

            _context.Grps.Remove(grp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrpExists(int id)
        {
            return _context.Grps.Any(e => e.CodGrp == id);
        }
    }
}

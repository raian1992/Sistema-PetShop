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
    public class EmpresaVeterinariosController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public EmpresaVeterinariosController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/EmpresaVeterinarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpresaVeterinario>>> GetEmpresaVeterinarios()
        {
            return await _context.EmpresaVeterinarios.ToListAsync();
        }

        // GET: api/EmpresaVeterinarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaVeterinario>> GetEmpresaVeterinario(int id)
        {
            var empresaVeterinario = await _context.EmpresaVeterinarios.FindAsync(id);

            if (empresaVeterinario == null)
            {
                return NotFound();
            }

            return empresaVeterinario;
        }

        // PUT: api/EmpresaVeterinarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresaVeterinario(int id, EmpresaVeterinario empresaVeterinario)
        {
            if (id != empresaVeterinario.IdAssociacao)
            {
                return BadRequest();
            }

            _context.Entry(empresaVeterinario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaVeterinarioExists(id))
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

        // POST: api/EmpresaVeterinarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpresaVeterinario>> PostEmpresaVeterinario(EmpresaVeterinario empresaVeterinario)
        {
            _context.EmpresaVeterinarios.Add(empresaVeterinario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpresaVeterinario", new { id = empresaVeterinario.IdAssociacao }, empresaVeterinario);
        }

        // DELETE: api/EmpresaVeterinarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresaVeterinario(int id)
        {
            var empresaVeterinario = await _context.EmpresaVeterinarios.FindAsync(id);
            if (empresaVeterinario == null)
            {
                return NotFound();
            }

            _context.EmpresaVeterinarios.Remove(empresaVeterinario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpresaVeterinarioExists(int id)
        {
            return _context.EmpresaVeterinarios.Any(e => e.IdAssociacao == id);
        }
    }
}

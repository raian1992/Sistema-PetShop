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
    public class EmpresaUsuariosController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public EmpresaUsuariosController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/EmpresaUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpresaUsuario>>> GetEmpresaUsuarios()
        {
            return await _context.EmpresaUsuarios.ToListAsync();
        }

        // GET: api/EmpresaUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaUsuario>> GetEmpresaUsuario(int id)
        {
            var empresaUsuario = await _context.EmpresaUsuarios.FindAsync(id);

            if (empresaUsuario == null)
            {
                return NotFound();
            }

            return empresaUsuario;
        }

        // PUT: api/EmpresaUsuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresaUsuario(int id, EmpresaUsuario empresaUsuario)
        {
            if (id != empresaUsuario.IdAssociacao)
            {
                return BadRequest();
            }

            _context.Entry(empresaUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaUsuarioExists(id))
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

        // POST: api/EmpresaUsuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpresaUsuario>> PostEmpresaUsuario(EmpresaUsuario empresaUsuario)
        {
            _context.EmpresaUsuarios.Add(empresaUsuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpresaUsuarioExists(empresaUsuario.IdAssociacao))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmpresaUsuario", new { id = empresaUsuario.IdAssociacao }, empresaUsuario);
        }

        // DELETE: api/EmpresaUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresaUsuario(int id)
        {
            var empresaUsuario = await _context.EmpresaUsuarios.FindAsync(id);
            if (empresaUsuario == null)
            {
                return NotFound();
            }

            _context.EmpresaUsuarios.Remove(empresaUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpresaUsuarioExists(int id)
        {
            return _context.EmpresaUsuarios.Any(e => e.IdAssociacao == id);
        }
    }
}

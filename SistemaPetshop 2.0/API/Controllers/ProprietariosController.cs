﻿using System;
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
    public class ProprietariosController : ControllerBase
    {
        private readonly LOJA_PETContext _context;

        public ProprietariosController(LOJA_PETContext context)
        {
            _context = context;
        }

        // GET: api/Proprietarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietario>>> GetProprietarios()
        {
            return await _context.Proprietarios.ToListAsync();
        }

        // GET: api/Proprietarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proprietario>> GetProprietario(int id)
        {
            var proprietario = await _context.Proprietarios.FindAsync(id);

            if (proprietario == null)
            {
                return NotFound();
            }

            return proprietario;
        }

        // PUT: api/Proprietarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProprietario(int id, Proprietario proprietario)
        {
            if (id != proprietario.IdProprietario)
            {
                return BadRequest();
            }

            _context.Entry(proprietario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(id))
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

        // POST: api/Proprietarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Proprietario>> PostProprietario(Proprietario proprietario)
        {
            _context.Proprietarios.Add(proprietario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProprietario", new { id = proprietario.IdProprietario }, proprietario);
        }

        // DELETE: api/Proprietarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProprietario(int id)
        {
            var proprietario = await _context.Proprietarios.FindAsync(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            _context.Proprietarios.Remove(proprietario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProprietarioExists(int id)
        {
            return _context.Proprietarios.Any(e => e.IdProprietario == id);
        }
    }
}

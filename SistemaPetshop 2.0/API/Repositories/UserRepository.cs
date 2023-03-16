using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.security;

namespace API.Repositories
{
    public class UserRepository
    {
        private static
             LOJA_PETContext _context;

        public UserRepository(LOJA_PETContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public static async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        //{
        //    return await  _context.Usuarios.ToListAsync<Usuario>();
        //}
        public static Usuario Get(string username, string password)
        {

            //List<Usuario> user = _context.Usuarios.ToList<Usuario>();

            LOJA_PETContext db = new LOJA_PETContext();
            var usu = db.Usuarios.ToList<Usuario>();
            return usu.Where(x => x.LOgin.ToLower() == username.ToLower()
            && Cript.descriptografarsenha(x.Senha) == password).FirstOrDefault();

            //return user.Where(x => x.LOgin.ToLower() == username.ToLower() 
            //&&   Cript.descriptografarsenha( x.Senha) == password).FirstOrDefault();
        }


    }
}

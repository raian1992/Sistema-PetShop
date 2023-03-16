using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace API
{
    public class AppDbContext : DbContext
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager<>);
        //    // optionsBuilder.UseSqlServer(ConfigurationManager<string>.ConnectionStrings["ConnectionString"].ConnectionString);
        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        { 
        }

        //se a tabela do sistema estiver no singular ao dbset deve esta no singular
        public DbSet<CFOP> CFOP { get; set; }
        public DbSet<CEP> CEP { get; set; }
    }
}

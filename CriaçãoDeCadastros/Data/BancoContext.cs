using CriaçãoDeCadastros.Controllers;
using CriaçãoDeCadastros.Models;
using Microsoft.EntityFrameworkCore;

namespace CriaçãoDeCadastros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}

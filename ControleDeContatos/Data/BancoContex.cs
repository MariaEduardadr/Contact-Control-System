using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContex : Microsoft.EntityFrameworkCore.DbContext
    {
        public BancoContex(DbContextOptions<BancoContex> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; } 


        
    }
}

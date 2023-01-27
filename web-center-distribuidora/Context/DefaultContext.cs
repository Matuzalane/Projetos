using Microsoft.EntityFrameworkCore;
using web_center_distribuidora.Models;

namespace web_center_distribuidora.Context
{
    public class DefaultContext : DbContext
    {
         public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }

        public DbSet<PessoaFisica> PessoasFisicas{ get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas{ get; set; }
        public DbSet<Contato> Contatos{ get; set; }
        public DbSet<Produto> Produtos{ get; set; }
        public DbSet<Grupo> Grupos{ get; set; }
        public DbSet<Estoque> Estoques{ get; set; }

    }
}
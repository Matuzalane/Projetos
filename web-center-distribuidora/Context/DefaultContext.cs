using Microsoft.EntityFrameworkCore;
using web_center_distribuidora.Models;

namespace web_center_distribuidora.Context
{
    public class DefaultContext : DbContext
    {
         public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<NotaFiscal> NotaFiscais { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Movimentacao>()
        //         .HasMany(m => m.notasFiscais)
        //         .WithOne()
        //         .HasForeignKey(nf => nf.movimentacaoId);
        // }
    }
}
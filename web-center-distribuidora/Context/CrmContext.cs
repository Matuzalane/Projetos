using Microsoft.EntityFrameworkCore;
using web_center_distribuidora.ModelsCrm;

namespace web_center_distribuidora.Context
{
    public class CrmContext : DbContext
    {
         public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {
        }

        public DbSet<CrmProduto> Produtos { get; set; }
        public DbSet<CrmEstoque> Estoques { get; set; }
        public DbSet<CrmGrupo> Grupos { get; set; }

        public DbSet<CrmPessoa> Pessoas { get; set; }
        public DbSet<CrmPessoaContato> Pessoas_Contatos { get; set; }
        public DbSet<CrmPessoaEndereco> Pessoas_Enderecos { get; set; }

        public DbSet<CrmMovimentacao> Movimentacao { get; set; }
        public DbSet<CrmMovimentacaoItem> MovItens { get; set; }
    }
}
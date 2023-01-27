using Microsoft.EntityFrameworkCore;
using web_center_distribuidora.Models;

namespace web_center_distribuidora.Context
{
    public class CrmContext : DbContext
    {
         public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }

        public DbSet<CrmProduto> Produtos{ get; set; }
        public DbSet<CrmPessoa> Pessoas{ get; set; }
    }
}
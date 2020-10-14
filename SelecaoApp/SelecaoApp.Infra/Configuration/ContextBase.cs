using Microsoft.EntityFrameworkCore;

namespace SelecaoApp.Infra.Configuration
{
    public class ContextBase : DbContext
    {
        public DbSet<Domain.Models.LoginModels.Login> Login { get; set; }
        public DbSet<Domain.Models.FornecedoresModels.Fornecedores> Fornecedores { get; set; }
        public DbSet<Domain.Models.ProdutosModels.Produtos> Produtos { get; set; }
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DBEntities db = new DBEntities();
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(db.Database.Connection.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

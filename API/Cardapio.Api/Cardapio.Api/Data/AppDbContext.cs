using Cardapio.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Item> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Categoria)
                .WithMany(c => c.Itens)
                .HasForeignKey(i => i.CategoriaPublicId)
                .HasPrincipalKey(c => c.PublicId);
        }
    }
}

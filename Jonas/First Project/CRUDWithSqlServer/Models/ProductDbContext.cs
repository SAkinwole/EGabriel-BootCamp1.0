#nullable disable
using Microsoft.EntityFrameworkCore;

namespace CRUDWithSqlServer.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(250);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}

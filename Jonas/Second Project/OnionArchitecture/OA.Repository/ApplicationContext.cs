using Microsoft.EntityFrameworkCore;
using OA.DataAccess;

namespace OA.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = new ProductMap(modelBuilder.Entity<Product>());
            _ = new ProductDetailMap(modelBuilder.Entity<ProductDetails>());
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithSql.Models.Products;

namespace SimpleWebApiWithSql.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Product> Products => Set<Product>();
    }
}

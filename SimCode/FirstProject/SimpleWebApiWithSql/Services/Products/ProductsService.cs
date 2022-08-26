using Microsoft.EntityFrameworkCore;
using SimpleWebApiWithSql.Data;
using SimpleWebApiWithSql.Models.Products;

namespace SimpleWebApiWithSql.Services.Products
{
    public class ProductsService : IProductsService
    {
        private readonly DataContext _context;

        public ProductsService(DataContext context)
        {
            _context = context;
        }

        public async void AddProduct(Product product)
        {
             _context.Products.Add(product); 
            _context.SaveChanges();
        }

        public async void DeletProduct(int id)
        {
            var uProduct = await _context.Products.FindAsync(id);
            if (uProduct == null) return;

            _context.Products.Remove(uProduct);
            await _context.SaveChangesAsync();    
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return null!;
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async void UpdateProduct(Product product)
        {
            var uProduct = await _context.Products.FindAsync(product.Id);
            if (uProduct == null) return;

            product.Name = product.Name;
            product.Description = product.Description;
            product.Price = product.Price;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}

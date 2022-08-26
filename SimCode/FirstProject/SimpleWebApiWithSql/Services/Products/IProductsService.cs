using SimpleWebApiWithSql.Models.Products;

namespace SimpleWebApiWithSql.Services.Products
{
    public interface IProductsService 
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeletProduct(int id);
    }
}

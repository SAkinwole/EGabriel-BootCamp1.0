using CRUDWithMongoDB.Models;
using MongoDB.Entities;

namespace CRUDWithMongoDB.Services
{
    public class ProductRepository : IProductRepository
    {
        public async Task Create(Product product)
        {
            await product.SaveAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await DB.Find<Product>().Match(_ => true).ExecuteAsync();
        }

        public async Task<Product> Get(string id)
        {
            return await DB.Find<Product>().MatchID(id).ExecuteFirstAsync();
        }

        public async Task<Product> Update(string id, Product product)
        {
            return await DB.UpdateAndGet<Product>().MatchID(id).ModifyWith(product).ExecuteAsync();
        }

        public async Task<bool> Delete(string id)
        {
            var result = await DB.DeleteAsync<Product>(id);
            return result.IsAcknowledged;
        }
    }
}

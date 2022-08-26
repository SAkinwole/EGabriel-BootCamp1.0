using OA.DataAccess;

namespace OA.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProduct();

        Product GetProduct(int id);
    }
}
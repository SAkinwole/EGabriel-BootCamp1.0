using OA.DataAccess;

namespace OA.Service
{
    public interface IProductDetailsService  
    {
        ProductDetails GetProductDetails(int id);
    }
}
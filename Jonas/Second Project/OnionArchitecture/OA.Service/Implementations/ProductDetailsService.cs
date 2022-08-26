using OA.DataAccess;
using OA.Repository;

namespace OA.Service
{
    public class ProductDetailsService : IProductDetailsService
    {
        private readonly IRepository<ProductDetails> _productDetailsRepository;

        public ProductDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetProductDetails(int id)
        {
            return _productDetailsRepository.Get(id);
        }
    }
}
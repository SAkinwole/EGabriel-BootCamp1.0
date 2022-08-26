using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Service;

namespace OA.UI
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductDetailsService _productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            _productService = productService;
            _productDetailsService = productDetailsService;
        }

        [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new();
            var productList = _productService.GetProduct().ToList();

            foreach (var product in productList)
            {
                var productDetailsList = _productDetailsService.GetProductDetails(product.ProductId);

                ProductDetails details = new()
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = productDetailsList.Price,
                    StockAvailable = productDetailsList.StockAvailable
                };

                productDetails.Add(details);
            }

            return productDetails;
        }
    }
}
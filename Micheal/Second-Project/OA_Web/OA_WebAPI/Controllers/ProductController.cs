using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Service;

namespace OA_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService,IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }
        [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var productList = productService.GetProducts().ToList();
            foreach(var product in productList)
            {
                var productDetailList = productDetailsService.GetProductDetail(product.ProductId);
                ProductDetails details = new ProductDetails
                {
                    ProductId = product.ProductId,
                    Price = productDetailList.Price,
                    StockAvailable = productDetailList.StockAvailable,
                    ProductName = product.ProductName
                };
                productDetails.Add(details);    

            }
            return productDetails;
        }
    }
}

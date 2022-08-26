using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace OA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = _productService.GetProduct().ToList();
            foreach (var product in prodcutList)
            {
                var productDetailList = _productDetailsService.GetProductDetail(product.ProductId);
                ProductDetails details = new ProductDetails
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = productDetailList.Price,
                    StockAvailable = productDetailList.StockAvailable,
                };
                productDetails.Add(details);
            }
            return productDetails;
        }

            
    
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApiWithSql.Models.Products;
using SimpleWebApiWithSql.Services.Products;

namespace SimpleWebApiWithSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsService _productService;

        public ProductsController(IProductsService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
             _productService.AddProduct(product);
            return Ok("Product Created");
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
             _productService.UpdateProduct(product);
            return Ok("Product Updated");
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            _productService.DeletProduct(Id);
            return Ok("Product Deleted");
        }

    }
}

using CRUDWithMongoDB.Models;
using CRUDWithMongoDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithMongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _products;

        public ProductsController(IProductRepository products)
        {
            _products = products;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _products.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var product = await _products.Get(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            await _products.Create(product);
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Product product)
        {
            if (product is null) return BadRequest();
            
            var p = await _products.Get(product.ID);
            if (p is null) return NotFound();

            await _products.Update(product.ID, product);
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var product = await _products.Get(id);
            if (product is null) return NotFound();

            await _products.Delete(id);
            return Ok();
        }
    }
}
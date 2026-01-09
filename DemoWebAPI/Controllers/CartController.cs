using DemoWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        public CartController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        // GET: api/<CartController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            // Retrieve products from cache
            if (_memoryCache.TryGetValue("cartProducts", out List<Product> cachedProducts))
            {
                return Ok(cachedProducts);
            }

            // Return empty list if no products in cache
            return Ok(new List<Product>());
        }

        // POST api/<CartController>
        [HttpPost]
        public ActionResult<List<Product>> Post([FromBody] List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                return Ok((List<Product>)null);
            }
            // Retrieve existing products from cache
            if (_memoryCache.TryGetValue("cartProducts", out List<Product> cachedProducts))
            {
                // Add new products to the existing cached products
                cachedProducts.AddRange(products);
                _memoryCache.Set("cartProducts", cachedProducts, TimeSpan.FromHours(1));
                return Ok(cachedProducts);
            }

            // If no cache exists, create new cache with the products
            _memoryCache.Set("cartProducts", products, TimeSpan.FromHours(1));

            return Ok(products);
        }
    }
}

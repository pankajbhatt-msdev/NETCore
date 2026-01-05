using DemoWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        // POST api/<CartController>
        [HttpPost]
        public ActionResult<List<Product>> Post([FromBody] List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                return Ok((List<Product>)null);
            }

            return Ok(products);
        }
    }
}

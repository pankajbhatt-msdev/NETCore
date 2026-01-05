using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            // Return an empty product collection as a placeholder; replace with data source retrieval
            return _products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Description = "A robot head with an unusually large eye and teloscpic neck -- excellent for exploring high spaces.",
                Name = "Large Cyclops",
                ImageName = "head-big-eye.png",
                Category = "Heads",
                Price = 1220.5m,
                Discount = 0.2m
            },
            new Product
            {
                Id = 17,
                Description = "A spring base - great for reaching high places.",
                Name = "Spring Base",
                ImageName = "base-spring.png",
                Category = "Bases",
                Price = 1190.5m,
                Discount = 0m
            },
            new Product
            {
                Id = 6,
                Description = "An articulated arm with a claw -- great for reaching around corners or working in tight spaces.",
                Name = "Articulated Arm",
                ImageName = "arm-articulated-claw.png",
                Category = "Arms",
                Price = 275m,
                Discount = 0m
            },
            new Product
            {
                Id = 2,
                Description = "A friendly robot head with two eyes and a smile -- great for domestic use.",
                Name = "Friendly Bot",
                ImageName = "head-friendly.png",
                Category = "Heads",
                Price = 945m,
                Discount = 0.2m
            },
            new Product
            {
                Id = 3,
                Description = "A large three-eyed head with a shredder for a mouth -- great for crushing light medals or shredding documents.",
                Name = "Shredder",
                ImageName = "head-shredder.png",
                Category = "Heads",
                Price = 1275.5m,
                Discount = 0m
            },
            new Product
            {
                Id = 16,
                Description = "A single-wheeled base with an accelerometer capable of higher speeds and navigating rougher terrain than the two-wheeled variety.",
                Name = "Single Wheeled Base",
                ImageName = "base-single-wheel.png",
                Category = "Bases",
                Price = 1190.5m,
                Discount = 0.1m
            },
            new Product
            {
                Id = 13,
                Description = "A simple torso with a pouch for carrying items.",
                Name = "Pouch Torso",
                ImageName = "torso-pouch.png",
                Category = "Torsos",
                Price = 785m,
                Discount = 0m
            },
            new Product
            {
                Id = 7,
                Description = "An arm with two independent claws -- great when you need an extra hand. Need four hands? Equip your bot with two of these arms.",
                Name = "Two Clawed Arm",
                ImageName = "arm-dual-claw.png",
                Category = "Arms",
                Price = 285m,
                Discount = 0m
            },
            new Product
            {
                Id = 4,
                Description = "A simple single-eyed head -- simple and inexpensive.",
                Name = "Small Cyclops",
                ImageName = "head-single-eye.png",
                Category = "Heads",
                Price = 750m,
                Discount = 0m
            },
            new Product
            {
                Id = 9,
                Description = "An arm with a propeller -- good for propulsion or as a cooling fan.",
                Name = "Propeller Arm",
                ImageName = "arm-propeller.png",
                Category = "Arms",
                Price = 230m,
                Discount = 0.1m
            },
            new Product
            {
                Id = 15,
                Description = "A rocket base capable of high speed, controlled flight.",
                Name = "Rocket Base",
                ImageName = "base-rocket.png",
                Category = "Bases",
                Price = 1520.5m,
                Discount = 0m
            },
            new Product
            {
                Id = 10,
                Description = "A short and stubby arm with a claw -- simple, but cheap.",
                Name = "Stubby Claw Arm",
                ImageName = "arm-stubby-claw.png",
                Category = "Arms",
                Price = 125m,
                Discount = 0m
            },
            new Product
            {
                Id = 11,
                Description = "A torso that can bend slightly at the waist and equiped with a heat guage.",
                Name = "Flexible Gauged Torso",
                ImageName = "torso-flexible-gauged.png",
                Category = "Torsos",
                Price = 1575m,
                Discount = 0m
            },
            new Product
            {
                Id = 14,
                Description = "A two wheeled base with an accelerometer for stability.",
                Name = "Double Wheeled Base",
                ImageName = "base-double-wheel.png",
                Category = "Bases",
                Price = 895m,
                Discount = 0m
            },
            new Product
            {
                Id = 5,
                Description = "A robot head with three oscillating eyes -- excellent for surveillance.",
                Name = "Surveillance",
                ImageName = "head-surveillance.png",
                Category = "Heads",
                Price = 1255.5m,
                Discount = 0m
            },
            new Product
            {
                Id = 8,
                Description = "A telescoping arm with a grabber.",
                Name = "Grabber Arm",
                ImageName = "arm-grabber.png",
                Category = "Arms",
                Price = 205.5m,
                Discount = 0m
            },
            new Product
            {
                Id = 12,
                Description = "A less flexible torso with a battery gauge.",
                Name = "Gauged Torso",
                ImageName = "torso-gauged.png",
                Category = "Torsos",
                Price = 1385m,
                Discount = 0m
            },
            new Product
            {
                Id = 18,
                Description = "An inexpensive three-wheeled base. only capable of slow speeds and can only function on smooth surfaces.",
                Name = "Triple Wheeled Base",
                ImageName = "base-triple-wheel.png",
                Category = "Bases",
                Price = 700.5m,
                Discount = 0m
            }
        };
    }
}

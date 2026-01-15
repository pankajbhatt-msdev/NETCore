using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null");
            }

            // Match user details with _users array
            var matchedUser = _users.FirstOrDefault(u =>
                u.Email == user.Email &&
                u.Password == user.Password);

            if (matchedUser != null)
            {
                return Ok(matchedUser);
            }

            return Unauthorized("User not found. Please check your credentials.");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly List<User> _users = new List<User>()
        {
            new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@yopmail.com",
                Password = "Password123"
            },
            new User
            {
                FirstName = "Michael",
                LastName = "Smith",
                Email = "msmith@yopmail.com",
                Password = "very-secret"
            },
            new User
            {
                FirstName = "Johnny",
                LastName = "Bairstow",
                Email = "johnnyb@yopmail.com",
                Password = "super-secret"
            }
        };
    }
}

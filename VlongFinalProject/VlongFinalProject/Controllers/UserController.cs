using VlongFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VlongFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public static List<User> users = new List<User>();

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = users.FirstOrDefault(t => t.UserID == id);

            if (user == null)
            {
                return NotFound(null);
            }

            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User value)
        {
            int userID = 1000;
            if(users.Count != 0)
            {
                userID = users[users.Count-1].UserID + 1;
            }
            
            value.UserID = userID;
            value.Created = DateTime.Now;
            users.Add(value);
            return StatusCode(201);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User value)
        {

            User toUpdate = users.FirstOrDefault(t => t.UserID == id);

            if (toUpdate != null)
            {
                toUpdate.Email = value.Email;
                toUpdate.Password = value.Password;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User found = users.FirstOrDefault(t => t.UserID == id);
            if(found != null)
            {
                users.Remove(found);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}

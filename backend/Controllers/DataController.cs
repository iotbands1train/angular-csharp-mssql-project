using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourProject.Models;
using YourProject.Services;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly DataService _dataService;

        public DataController(DataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/data
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _dataService.GetAllUsers();
            return Ok(users);
        }

        // GET: api/data/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _dataService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/data
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _dataService.AddUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/data/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            _dataService.UpdateUser(user);
            return NoContent();
        }

        // DELETE: api/data/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _dataService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            _dataService.DeleteUser(user);
            return NoContent();
        }
    }
}

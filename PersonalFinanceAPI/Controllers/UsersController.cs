using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.Data;
using PersonalFinanceAPI.Models;

namespace PersonalFinanceAPI.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly PersonalFinanceContext _context;

        public UsersController(PersonalFinanceContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] Guid id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            return Ok(user);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var allUsers = _context.Users.ToArray();

                return Ok(allUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser(PostUsersRequest user)
        {
            try
            {
                var userToCreate = new Users()
                {
                    Id = Guid.NewGuid(),
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CreatedAt = DateTime.UtcNow
                };
                _context.Users.Add(userToCreate);
                _context.SaveChanges();

                return Ok(userToCreate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Update user
        // PATCH /user/{id}


        // DELETE /user/{id}

    }

    public class PostUsersRequest
    {
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}

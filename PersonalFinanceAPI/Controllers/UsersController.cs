using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalFinanceAPI.Data;
using PersonalFinanceAPI.DTO;
using PersonalFinanceAPI.Models;

namespace PersonalFinanceAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
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
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(user);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var allUsers = await _context.Users.ToArrayAsync();

            return Ok(allUsers);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] UsersDTO user)
        {
            var userToCreate = new Users()
            {
                Id = Guid.NewGuid(),
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreatedAt = DateTime.UtcNow
            };

            await _context.Users.AddAsync(userToCreate);
            await _context.SaveChangesAsync();

            return Ok(userToCreate);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateUser(
            [FromRoute] Guid id, 
            [FromBody] UsersDTO user)
        {
            var foundUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (foundUser == null)
                return NotFound();

            foundUser.Email = user.Email ?? foundUser.Email;
            foundUser.FirstName = user.FirstName ?? foundUser.FirstName;
            foundUser.LastName = user.LastName ?? foundUser.LastName;
            foundUser.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(foundUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            await _context.Users.Where(u => u.Id == id).ExecuteDeleteAsync();
            return Ok();
        }
    }
}

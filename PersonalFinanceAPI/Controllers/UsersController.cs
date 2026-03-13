using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("/users")]
        public async Task<IActionResult> Get()
        {
            return Ok("\"Hello\": \"World\"");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.Data;

namespace PersonalFinanceAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly PersonalFinanceContext _context;

        public AccountsController(PersonalFinanceContext context)
        {
            _context = context;
        }

        // Create account

        // Get accounts for user

        // Get account by ID

        // Update account
    }
}

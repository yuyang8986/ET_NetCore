using System.Threading.Tasks;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ET_NetCore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly ETContext _context;

        public AccountController(ETContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            User user = await _context.Users.FirstOrDefaultAsync(s => s.Id == id);
            
            return Ok(user);
        }
    }
}
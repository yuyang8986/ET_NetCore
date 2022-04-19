using ET.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ET_NetCore.API.Controllers
{
    //business sub accounts management TODO
    //Only Business Main Account can edit its sub accounts TODO
    [Authorize(Roles = "BusinessMainAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessSubAccountsController : BaseController
    {
        private readonly ETContext _context;

        public BusinessSubAccountsController(ETContext context)
        {
            _context = context;
        }


        //[HttpGet]
        //public async IActionResult GetAllSubAccounts()
        //{
        //    var subAccounts = await _context.Users.OrderBy(u => u.UserName).Select(s => new
        //    {
        //        id = s.Id,
        //        UserName = s.UserName,
        //        Roles = _context.UserRoles.Join(_context.Roles, ur => ur.RoleId, r => r.Id, (ur, r) =>
        //        {
        //            r.Name
        //        })
        //    }).ToListAsync();
        //}

    }
}
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ET.Application.CQRS.IITR.IndividualDashboardCommand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ET_NetCore.API.Controllers.IITR
{
    [Authorize(Roles = "Individual")]
    [Route("api/[controller]")]
    [ApiController]
    public class IITRIndividualDashboardController : BaseController
    {
        /// <summary>
        /// Get Current Individual Dashboard Data
        /// </summary>
        /// <returns>IITRIndividualDashboardDto</returns>
        [HttpGet("index", Name = "DashboardIndex")]
        public async Task<IActionResult> Index()
        {
            var result = await Mediator.Send(new IITRIndividualDashboardCommand());
            return Ok(result);
        }

    }
}
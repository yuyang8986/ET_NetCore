using System.Threading.Tasks;
using ET.Application.CQRS.Individual.IndividualCommand;
using ET.Application.CQRS.Individual.IndividualQuery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers.Individual
{
    [Authorize(Roles = "Individual,BusinessMainAccount,BusinessSubAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualController : BaseController
    {
        /// <summary>
        /// /api/individual/params
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(IndividualUpdateCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            IndividualGetQuery query = new IndividualGetQuery{Id = id};
            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
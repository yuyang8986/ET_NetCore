using System.Threading.Tasks;
using ET.Infrastructure.DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers.IITR
{
    [Authorize(Roles = "BusinessMainAccount, BusinessSubAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class IITRBusinessController : BaseController
    {
        private readonly IIndividualRepository _repo;

        public IITRBusinessController(IIndividualRepository repo)
        {
            _repo = repo;
        }

        //only business accounts can get all individuals
        [Authorize(Roles = "BusinessMainAccount")]
        [HttpGet]
        public async Task<IActionResult> GetIndividuals()
        {
            var individuals = await _repo.GetIndividuals();
            return Ok(individuals);
        }

      
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers.IITR
{
    //related to prefill from ATO TODO
    [Authorize(Roles = "Individual,BusinessMainAccount,BusinessSubAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class IITRPrefillsController : BaseController
    {
    }
}
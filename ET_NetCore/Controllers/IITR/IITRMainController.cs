using System.Net;
using System.Threading.Tasks;
using ET.Application.CQRS.DeductionTypeDetailQuery.Get;
using ET.Application.CQRS.DeductionTypesQuery.GetAll;
using ET.Application.CQRS.IITR.BasicDetailsFormCommand.Add;
using ET.Application.CQRS.IITR.BasicDetailsFormCommand.Update;
using ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Add;
using ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update;
using ET.Application.CQRS.IITR.DeductionTypesFormCommand.Add;
using ET.Application.CQRS.IITR.DeductionTypesFormCommand.Update;
using ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.AddCommand;
using ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand;
using ET.Application.CQRS.IITR.IncomeTypesFormCommand.Add;
using ET.Application.CQRS.IITR.IncomeTypesFormCommand.Update;
using ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormAdd;
using ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet;
using ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Add;
using ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Update;
using ET.Application.CQRS.IITR.OtherTypesFormCommand.Add;
using ET.Application.CQRS.IITR.OtherTypesFormCommand.Update;
using ET.Application.CQRS.IncomeTypesQuery.GetAll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers.IITR
{
    [Authorize(Roles="Individual,BusinessMainAccount,BusinessSubAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class IITRMainController : BaseController
    {
        [HttpGet("{id:int}", Name = "GetMainForm")]
        public async Task<IActionResult> Get(int id)
        {
            MainFormGetQuery command = new MainFormGetQuery{Id = id};
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("GetMainFormIdByYear", Name = "GetMainFormIdByYear")]
        public async Task<IActionResult> GetMainFormIdByYear(MainFormIdGetQuery mainFormIdGetQuery)
        {
            var result = await Mediator.Send(mainFormIdGetQuery);
            return Ok(result);
        }

        /// <summary>
        /// /api/iitrmain/add
        /// will create a new mainform and lodgement for individual
        /// </summary>  
        /// <returns>mainform created</returns>
        [HttpPost]
        [Route("Add", Name = "AddMainForm")]
        public async Task<IActionResult> Add(MainFormAddCommand command)
        {
            var result = await Mediator.Send(command);
            return CreatedAtRoute("GetMainForm", new { id = result.MainFormId }, result);
        }

        [HttpPost]
        [Route("BasicDetails", Name = "AddBasicDetailsForm")]
        public async Task<IActionResult> AddBasicDetailsForm(BasicDetailsFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("BasicDetails", Name = "UpdateBasicDetailsForm")]
        public async Task<IActionResult> UpdateBasicDetailsForm(BasicDetailsFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpPost]
        [Route("IncomeTypesForm", Name = "AddIncomeTypesForm")]
        public async Task<IActionResult> AddIncomeTypesForm(IncomeTypesFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("IncomeTypesForm", Name = "UpdateIncomeTypesForm")]
        public async Task<IActionResult> UpdateIncomeTypesForm(IncomeTypesFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPost]
        [Route("IncomeDetailsForm", Name = "AddIncomeDetailsForm")]
        public async Task<IActionResult> AddIncomeDetailsForm(IncomeTypeDetailsFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("IncomeDetailsForm", Name = "UpdateIncomeDetailsForm")]
        public async Task<IActionResult> UpdateIncomeDetailsForm(IncomeTypeDetailsFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        [Route("IncomeTypes")]
        public async Task<IActionResult> GetAllIncomeTypes()
        {
            var query = new IncomeTypesGetAllQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("DeductionTypes")]
        public async Task<IActionResult> GetAllDeductionTypes(DeductionTypesGetAllQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }


        [HttpPost]
        [Route("DeductionTypesForm", Name = "AddDeductionTypesForm")]
        public async Task<IActionResult> AddDeductionTypesForm(DeductionTypesFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("DeductionTypesForm", Name = "UpdateDeductionTypesForm")]
        public async Task<IActionResult> UpdateDeductionTypesForm(DeductionTypesFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPost]
        [Route("DeductionDetailsForm", Name = "AddDeductionDetailsForm")]
        public async Task<IActionResult> AddDeductionDetailsForm(DeductionTypeDetailsFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("DeductionDetailsForm", Name = "UpdateDeductionDetailsForm")]
        public async Task<IActionResult> UpdateDeductionDetailsForm(DeductionTypeDetailsFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }


        [HttpPost]
        [Route("OtherItemTypesForm", Name = "AddOtherItemTypesForm")]
        public async Task<IActionResult> AddOtherItemTypesForm(OtherTypesFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("OtherItemTypesForm", Name = "UpdateOtherItemTypesForm")]
        public async Task<IActionResult> UpdateOtherItemTypesForm(OtherTypesFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPost]
        [Route("OtherItemDetailsForm", Name = "AddOtherItemDetailsForm")]
        public async Task<IActionResult> AddOtherItemDetailsForm(OtherItemTypeDetailsFormAddCommand command)
        {
            await Mediator.Send(command);
            return StatusCode(201);
        }

        [HttpPut]
        [Route("OtherItemDetailsForm", Name = "UpdateOtherItemDetailsForm")]
        public async Task<IActionResult> UpdateOtherItemDetailsForm(OtherTypeDetailsFormUpdateCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

    }
}
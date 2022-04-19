using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ET.Application.CQRS.DeductionTypeDetailQuery.Get;
using ET.Application.CQRS.IncomeTypeDetailQuery.Get;
using ET.Application.CQRS.OtherItemTypeDetailQuery.Get;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers.IITR
{
    [Authorize(Roles = "Individual,BusinessMainAccount,BusinessSubAccount")]
    [Route("api/[controller]")]
    [ApiController]
    public class IITRFormDetailsController : BaseController
    {
        [HttpGet]
        [Route("OtherItemTypeDetail/{id:int}", Name = "GetOtherItemTypeDetail")]
        public async Task<IActionResult> GetOtherItemTypeDetail(int id)
        {
            OtherItemTypeDetailGetQuery command = new OtherItemTypeDetailGetQuery { OtherItemTypeDetailId = id };
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("OtherItemTypeDetail", Name = "GetOtherItemTypeDetails")]
        public async Task<IActionResult> GetOtherItemTypeDetails(params int[] ids)
        {
            List<OtherItemTypeDetail> otherItemTypeDetails = new List<OtherItemTypeDetail>();
            foreach (var id in ids)
            {
                OtherItemTypeDetailGetQuery command = new OtherItemTypeDetailGetQuery { OtherItemTypeDetailId = id };
                var result = await Mediator.Send(command);
                otherItemTypeDetails.Add(result);
            }

            return Ok(otherItemTypeDetails);
        }

        [HttpGet]
        [Route("IncomeTypeDetail/{id:int}", Name = "GetIncomeTypeDetail")]
        public async Task<IActionResult> GetIncomeTypeDetail(int id)
        {
            IncomeTypeDetailGetQuery command = new IncomeTypeDetailGetQuery { IncomeTypeDetailId = id };
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("DeductionTypeDetail/{id:int}", Name = "GetDeductionTypeDetail")]
        public async Task<IActionResult> GetDeductionTypeDetail(int id)
        {
            DeductionTypeDetailGetQuery command = new DeductionTypeDetailGetQuery { DeductionTypeDetailId = id };
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand
{
    public class IncomeTypeDetailsFormUpdateCommand : IRequest<Unit>
    {
        public int IncomeDetailsFormId { get; set; }

        public List<IncomeTypeDetailsFormUpdateDto> IncomeTypeDetails { get; set; }
    }
}

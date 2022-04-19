using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Update
{
    public class IncomeTypesFormUpdateCommand: IRequest<Unit>
    {
        public List<int> IncomeTypeIds { get; set; }

        public int Id { get; set; }

    }
}

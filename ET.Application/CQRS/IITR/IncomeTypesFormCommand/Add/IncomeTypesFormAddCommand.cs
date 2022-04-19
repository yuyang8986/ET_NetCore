using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Add
{
    public class IncomeTypesFormAddCommand: IRequest<Unit>
    {
        public List<int> IncomeTypeIds { get; set; }

        public int MainFormId { get; set; }

    }
}

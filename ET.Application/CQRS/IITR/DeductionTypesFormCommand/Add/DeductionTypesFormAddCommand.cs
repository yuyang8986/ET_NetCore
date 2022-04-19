using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Add
{
    public class DeductionTypesFormAddCommand: IRequest<Unit>
    {
        public List<int> DeductionTypeIds { get; set; }

        public int MainFormId { get; set; }

    }
}

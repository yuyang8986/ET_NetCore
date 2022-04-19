using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Update
{
    public class DeductionTypesFormUpdateCommand: IRequest<Unit>
    {
        public List<int> DeductionTypeIds { get; set; }

        public int Id { get; set; }

    }
}

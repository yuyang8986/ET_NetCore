using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update
{
    public class DeductionTypeDetailsFormUpdateCommand : IRequest<Unit>
    {
        public int DeductionDetailsFormId { get; set; }

        public List<DeductionTypeDetailsFormUpdateDto> DeductionTypeDetails { get; set; }
    }
}

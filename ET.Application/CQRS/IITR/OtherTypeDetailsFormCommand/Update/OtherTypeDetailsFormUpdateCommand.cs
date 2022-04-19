using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Update
{
    public class OtherTypeDetailsFormUpdateCommand : IRequest<Unit>
    {
        public int OtherDetailsFormId { get; set; }

        public List<OtherItemTypeDetailsFormUpdateDto> OtherItemTypeDetails { get; set; }
    }
}

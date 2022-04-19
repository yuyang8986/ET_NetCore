using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Update
{
    public class OtherTypesFormUpdateCommand : IRequest<Unit>
    {
        public List<int> OtherTypeIds { get; set; }

        public int Id { get; set; }

    }
}

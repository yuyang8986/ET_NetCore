using System.Collections.Generic;
using MediatR;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Add
{
    public class OtherTypesFormAddCommand : IRequest<Unit>
    {
        public List<int> OtherTypeIds { get; set; }

        public int MainFormId { get; set; }

    }
}

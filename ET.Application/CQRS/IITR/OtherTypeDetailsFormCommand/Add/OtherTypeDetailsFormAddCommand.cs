using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Add
{
    public class OtherItemTypeDetailsFormAddCommand : IRequest<Unit>
    {
        public int MainFormId { get; set; }

        public List<OtherItemTypeDetail> OtherTypeDetails { get; set; }
    }
}

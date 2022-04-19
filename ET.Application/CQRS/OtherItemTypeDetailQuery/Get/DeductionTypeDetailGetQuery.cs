using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.OtherItemTypeDetailQuery.Get
{
    public class OtherItemTypeDetailGetQuery : IRequest<OtherItemTypeDetail>
    {
        public int OtherItemTypeDetailId { get; set; }
    }
}

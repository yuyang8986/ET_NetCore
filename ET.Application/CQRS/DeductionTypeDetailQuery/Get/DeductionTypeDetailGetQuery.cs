using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.DeductionTypeDetailQuery.Get
{
    public class DeductionTypeDetailGetQuery : IRequest<DeductionTypeDetail>
    {
        public int DeductionTypeDetailId { get; set; }
    }
}

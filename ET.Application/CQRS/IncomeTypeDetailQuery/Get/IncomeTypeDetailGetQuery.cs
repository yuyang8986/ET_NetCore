using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.IncomeTypeDetailQuery.Get
{
    public class IncomeTypeDetailGetQuery : IRequest<IncomeTypeDetail>
    {
        public int IncomeTypeDetailId { get; set; }
    }
}

using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Add
{
    public class DeductionTypeDetailsFormAddCommand : IRequest<Unit>
    {
        public int MainFormId { get; set; }

        public List<DeductionTypeDetail> DeductionTypeDetails { get; set; }
    }
}

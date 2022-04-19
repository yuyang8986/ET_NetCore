using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using MediatR;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.AddCommand
{
    public class IncomeTypeDetailsFormAddCommand : IRequest<Unit>
    {
        public int MainFormId { get; set; }

        public List<IncomeTypeDetail> IncomeTypeDetails { get; set; }
    }
}

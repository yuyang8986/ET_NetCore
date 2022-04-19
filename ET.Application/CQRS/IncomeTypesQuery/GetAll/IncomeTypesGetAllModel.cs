using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Application.CQRS.IncomeTypesQuery.GetAll
{
    public class IncomeTypesGetAllModel
    {
        public IncomeTypesGetAllModel(List<IncomeType> incomeTypes)
        {
            IncomeTypes = incomeTypes;
        }

        public List<IncomeType> IncomeTypes { get;}
    }
}

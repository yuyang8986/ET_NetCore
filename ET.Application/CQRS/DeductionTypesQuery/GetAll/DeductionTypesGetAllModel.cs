using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using System;
using System.Collections.Generic;

namespace ET.Application.CQRS.DeductionTypesQuery.GetAll
{
    public class DeductionTypesGetAllModel
    {
        public List<DeductionType> DeductionTypes { get; set; }

        public DeductionTypesGetAllModel(List<DeductionType> deductionTypes)
        {
            DeductionTypes = deductionTypes;
        }
    }
}

﻿using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class InterestDeduction
    {
        public int InterestDeductionId { get; set; }
        public int Amount { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

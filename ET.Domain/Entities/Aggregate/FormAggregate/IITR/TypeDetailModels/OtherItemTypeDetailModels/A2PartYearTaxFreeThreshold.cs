using System;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class A2PartYearTaxFreeThreshold
    {
        public int A2PartYearTaxFreeThresholdId { get; set; }
        public DateTime ThresHoldDate { get; set; }
        public int NumberOfMonthsEligible { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

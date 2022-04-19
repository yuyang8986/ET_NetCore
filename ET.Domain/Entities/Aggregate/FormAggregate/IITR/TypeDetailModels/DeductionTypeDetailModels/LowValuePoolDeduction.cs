using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class LowValuePoolDeduction
    {
        public int LowValuePoolDeductionId { get; set; }
        public int AmountRelatedToFinancialInvestments { get; set; }
        public int AmountRelatedToRentalProperties { get; set; }
        public int OtherAmount  { get; set; }
        public int Total { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

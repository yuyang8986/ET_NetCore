using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D15OtherDeductions
    {
        public int D15OtherDeductionsId { get; set; }
        public string Description { get; set; }
        public int AmountRelatingToFinancialInvestmentsNotIncludedElseWhere { get; set; }
        public int AmountRelatingToRentalIncomeNotIncludedElseWhere { get; set; }
        public int AmountOtherDeduction { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }

    }
}

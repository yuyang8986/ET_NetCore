using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class ForeignSourceIncome //Foreign source income (including foreign source pension or annuity) and foreign assets or property
    {
        public int ForeignSourceIncomeId { get; set; }
        public int AssessableForeignSourceIncome { get; set; }
        public int OtherNetForeignEmploymentIncome { get; set; }
        public bool IsOtherNetForeignEmploymentIncomeProfit { get; set; }
        public int NetForeignPensionWithoutUndeductedPurchasePrice { get; set; }
        public bool IsNetForeignPensionWithoutUndeductedPurchasePriceProfit { get; set; }
        public int NetForeignPensionWithUndeductedPurchasePrice { get; set; }
        public bool IsNetForeignPensionWithUndeductedPurchasePriceProfit { get; set; }
        public int NetForeignRent { get; set; }
        public bool IsNetForeignRentProfit { get; set; }
        public int OtherNetForeignIncome { get; set; } //dividend income or managed investment scheme income from foreign companies - including from foreign partnerships
        public bool IsOtherNetForeignIncomeProfit { get; set; }
        public int OtherNetForeignSourceIncome { get; set; }
        public int IsOtherNetForeignSourceIncomeProfit { get; set; }
        public int FrankingCreditsFromNewZealandFrankingCompany { get; set; }
        public int NetForeignEmploymenyIncomePaymenySummary { get; set; }
        public bool IsNetForeignEmploymenyIncomePaymenySummaryProfit { get; set; }
        public int ExemptForeignEmploymentIncome { get; set; }
        public int ForeignIncomeTaxOffset { get; set; }
        public int HasInterestEarnedInAssestOutsideAUMoreThan5000AUD { get; set; }
        public int NonResidentForeignIncome { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

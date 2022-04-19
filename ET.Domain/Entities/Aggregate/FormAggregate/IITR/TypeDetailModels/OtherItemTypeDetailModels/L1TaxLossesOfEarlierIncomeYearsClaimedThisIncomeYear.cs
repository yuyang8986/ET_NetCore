using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear
    {
        public int L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYearId { get; set; }
        public int PrimaryProductionLossesCarriedForwardFromEarlierIncomeYears { get; set; }
        public int PrimarProductionLossesClaimedThisIncomeYear { get; set; }
        public int NonPrimaryProductionLossesCarriedForwardFromEarlierIncomeYears { get; set; }
        public int NonPrimaryProductionLossesCarriedThisIncomeYear { get; set; }
        public int TaxableIncomeOrLoss { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

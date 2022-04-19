using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class CapitalGainOrLosses
    {
        public int CapitalGainOrLossesId { get; set; }
        public bool HasCGTEventThisYear { get; set; }
        public bool HasAppliedExemptionOrRollover { get; set; }
        public string ExemptionOrRollOverCodeIfAny { get; set; } // A B C D E F I J K L M N O P R S T U V X
        public int NetCapitalGain { get; set; }
        public int TotalCurrentYearCG { get; set; }
        public int NetCapitalLossCarriedForwardToLaterIncomeYears { get; set; }
        public int CreditForForeignResidentCapitalGainsWithholding { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

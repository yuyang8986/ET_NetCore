using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class NetIncomeOrLossFromBusiness
    {
        public int NetIncomeOrLossFromBusinessId { get; set; }
        public int NetIncomeOrLossFromBusinessAmount { get; set; }
        public bool IsNetIncomeOrLossFromBusinessAmountProfit { get; set; }
        public int NetIncomeOrLossFromRentalPropertyBusiness { get; set; }
        public bool IsNetIncomeOrLossFromRentalPropertyBusinessProfit { get; set; }
        public int OtherIncomeOrLossToItem15 { get; set; }
        public bool IsOtherIncomeOrLossToItem15 { get; set; }
        public int NetSmallBusinessIncome { get; set; }
        public int NetIncomeLossFromBusinessTaxWithheldVoluntaryAgreement { get; set; }
        public int NetIncomeLossFromBusinessTaxWithheldABNNotQuoted { get; set; }
        public int NetIncomeLossFromBusinessTaxWithheldForeignResidentWithholdingExcludingCG { get; set; }
        public int NetIncomeLossFromBusinessTaxWithheldLabourHireOrOtherSpecifiedPayments { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }

    }
}

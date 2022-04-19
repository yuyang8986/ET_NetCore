using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P9BusinessLossActivity
    {
        public int P9BusinessLossActivityId { get; set; }
        public string DescriptionOfActivity { get; set; }
        public string IndustryCode { get; set; }
        public string PartnershipOrSoleTraderOrNone { get; set; }
        public string TypeOfLoss { get; set; }
        public string ReferenceForCodeFive { get; set; }
        public int Year { get; set; }
        public int Number { get; set; }
        public int DeferredNonCommercialLossFromAPriorYear { get; set; }
        public int NetLossAmount { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

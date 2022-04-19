using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class InternetAccessExpense
    {
        public int InternetAccessExpenseId { get; set; }
        public string ReasonForUsingInternetForWork { get; set; }
        public int PercentageForWork { get; set; }
        public int TotalCharge { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

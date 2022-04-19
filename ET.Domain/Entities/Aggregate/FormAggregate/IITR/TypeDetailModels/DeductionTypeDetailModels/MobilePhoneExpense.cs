using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class MobilePhoneExpense
    {
        public int MobilePhoneExpenseId { get; set; }
        public bool IsUsingPhoneForWork { get; set; }
        public int PercentageOfWorkUse { get; set; }
        public int TotalBilledAmount { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

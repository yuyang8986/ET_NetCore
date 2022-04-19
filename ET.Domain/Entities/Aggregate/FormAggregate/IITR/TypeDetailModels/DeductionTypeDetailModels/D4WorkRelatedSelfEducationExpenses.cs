using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D4WorkRelatedSelfEducationExpenses
    {
        public int D4WorkRelatedSelfEducationExpensesId { get; set; }
        public string TypeOfConnectionForWork { get; set; }//K, I , O
        public int TotalAmount { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

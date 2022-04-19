using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class OtherWorkRelatedExpenses
    {
        public int OtherWorkRelatedExpensesId { get; set; }
        public string Type { get; set; }
        public string Desciption { get; set; }
        public string TypeOfEvidence { get; set; }
        public int TotalAmount { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

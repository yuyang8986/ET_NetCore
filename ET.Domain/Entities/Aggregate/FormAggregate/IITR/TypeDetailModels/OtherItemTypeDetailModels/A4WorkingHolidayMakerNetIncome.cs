using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
   public class A4WorkingHolidayMakerNetIncome
    {
        public int A4WorkingHolidayMakerNetIncomeId { get; set; }
        public int Amount { get; set; }



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

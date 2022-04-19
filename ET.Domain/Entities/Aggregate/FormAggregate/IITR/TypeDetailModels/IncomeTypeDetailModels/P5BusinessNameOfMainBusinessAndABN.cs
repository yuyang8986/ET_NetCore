using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P5BusinessNameOfMainBusinessAndABN
    {
        public int P5BusinessNameOfMainBusinessAndABNId { get; set; }
        public string BusinessNameOfMainBusiness { get; set; }
        public string ABN { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

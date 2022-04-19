using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class ELSP //Employer Lump Sum Payment
    {
        public int ELSPId { get; set; }
        public int TaxWithHeld { get; set; }
        public int AmountA { get; set; }
        public string Code { get; set; } //either R or T
        public int FullAmountB { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

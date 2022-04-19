using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class Rent //Your Share
    {
        public int RentId { get; set; }
        public int GrossRent { get; set; }
        public int InterestDeduction { get; set; }
        public int CapitalWorksDeduction { get; set; }
        public int OtherRentalDeductions { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

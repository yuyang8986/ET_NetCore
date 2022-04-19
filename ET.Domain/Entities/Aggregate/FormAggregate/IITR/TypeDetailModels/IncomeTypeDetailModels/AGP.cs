using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class AGP //Australian Government Pensions , from Types.AGPTypes
    {
        public int AGPId { get; set; }
        public string Type { get; set; }
        public int TaxWithHeld { get; set; }
        public int TotalAmount { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

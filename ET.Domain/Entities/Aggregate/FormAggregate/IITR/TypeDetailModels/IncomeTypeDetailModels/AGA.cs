using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
  public class AGA //Australian Government Allowances
    {
        public int AGAId { get; set; }
        public string Type { get; set; } // from types.AGATypes
        public int TaxWithHeld { get; set; }
        public int TotalAllowance { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

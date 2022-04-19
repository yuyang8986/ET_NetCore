using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class Allowance
    {
        public int AllowanceId { get; set; }
        public int Amount { get; set; }
        public string AllowanceType { get; set; } //from Types.Allowance Types



        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }

    }
}

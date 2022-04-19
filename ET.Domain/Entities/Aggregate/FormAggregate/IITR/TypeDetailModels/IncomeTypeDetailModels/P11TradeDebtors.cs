using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P11TradeDebtors
    {
        public int P11TradeDebtorsId { get; set; }
        public int Amount { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

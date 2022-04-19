using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class Dividends
    {
        public int DividendsId { get; set; }
        public int TFNWithHeld { get; set; }
        public int Unfranked { get; set; }
        public int Franked { get; set; }
        public int FrankingCredit { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

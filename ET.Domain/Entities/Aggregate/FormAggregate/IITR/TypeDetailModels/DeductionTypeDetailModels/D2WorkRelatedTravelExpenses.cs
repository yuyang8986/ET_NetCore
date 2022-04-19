using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D2WorkRelatedTravelExpenses
    {
        public int D2WorkRelatedTravelExpensesId { get; set; }
        public string TypeOfTravelExpense { get; set; } // Airfares, accom, meals, taxi, bus, train, other
        public int TotalPaid { get; set; }
        public bool IsAnyTravelAllowanceListInPAYG { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }

    }
}

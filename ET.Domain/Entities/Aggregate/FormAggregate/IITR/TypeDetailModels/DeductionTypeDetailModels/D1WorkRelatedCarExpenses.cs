using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D1WorkRelatedCarExpenses
    {
        public int D1WorkRelatedCarExpensesId { get; set; }
        public bool HasUseCarForWorkRelatedTravel { get; set; }
        public string ReasonForUseCarForWork { get; set; }
        public int NumOfKiloMetersTravelledForWork { get; set; }
        public bool IsCarRegisteredUnderYourName { get; set; }
        public bool DidRecordAllTripsInCarBookFor12ContinuousWeeks { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

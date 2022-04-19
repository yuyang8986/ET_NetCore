using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class DeferredNonCommercialBusinessLosses
    {
        public int DeferredNonCommercialBusinessLossesId { get; set; }
        public int ShareOfDeferredLossesFromPartnershipCarryingBusinessOfInvesting { get; set; }
        public int ShareOfDeferredLossesFromPartnershipRentalBusiness { get; set; }
        public int ShareOfDeferredLossesFromPartnershipOthers { get; set; }
        public int ShareOfDeferredLossesFromPartnershipActivities { get; set; }
        public int DeferredLossesFromSoleTraderActivities { get; set; }
        public int PrimaryProductionDeferredLosses { get; set; }
        public int NonPrimaryProductionDeferredLosses { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

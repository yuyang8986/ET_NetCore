using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity
    {
        public int D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuityId { get; set; }
        public int Amount { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

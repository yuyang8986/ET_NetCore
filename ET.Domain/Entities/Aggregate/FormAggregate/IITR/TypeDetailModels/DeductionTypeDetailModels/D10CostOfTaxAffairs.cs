using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D10CostOfTaxAffairs
    {
        public int D10CostOfTaxAffairsId { get; set; }
        public int CostForManagingTaxLastYear { get; set; }
        public int InterestChargedByATO { get; set; }
        public int LegalOrLawyerCostForTaxAffairs { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P10SmallBusinessEntityDepreciatingAssets
    {
        public int P10SmallBusinessEntityDepreciatingAssetsId { get; set; }
        public int SmallBusinessEntitySimplifiedDepreciationDeductionForCertainAssets { get; set; }
        public int SmallBusinessEntitySimplifiedDepreciationDeductionForGeneralSmallBusinessPool { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

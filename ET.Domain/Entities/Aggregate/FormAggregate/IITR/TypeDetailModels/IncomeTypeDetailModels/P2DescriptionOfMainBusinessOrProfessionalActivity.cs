using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P2DescriptionOfMainBusinessOrProfessionalActivity
    {
        public int P2DescriptionOfMainBusinessOrProfessionalActivityId { get; set; }
        public string Description { get; set; }
        public string IndustryCode { get; set; }
        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

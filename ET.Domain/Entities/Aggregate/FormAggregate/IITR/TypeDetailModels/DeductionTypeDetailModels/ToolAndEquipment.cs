using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class ToolAndEquipment
    {
        public int ToolAndEquipmentId { get; set; }
        public int AddUpItemsCost300OrLess { get; set; }
        public string DescriptionAboutToolRelatedToWork { get; set; }
        public int AddUpItemsCost301OrMore { get; set; }
        public string DescriptionForItemsCost301OrMore { get; set; }
        public int PercentageOfTimeForWork { get; set; }
        public string TypeOfEvidence { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class M1MedicareLevyReductionOrExemption
    {
        public int M1MedicareLevyReductionOrExemptionId { get; set; }
        public int NumberOfDependentChildrenAndStudents { get; set; }
        public int NumberOfDaysFullLevyExemption { get; set; }
        public string NumberOfDaysFullLevyExemptionActionCode { get; set; }
        public int NumberOfDaysHalfLevyExemption { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

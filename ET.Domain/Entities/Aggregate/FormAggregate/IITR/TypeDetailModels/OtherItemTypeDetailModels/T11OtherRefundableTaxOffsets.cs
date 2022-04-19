using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T11OtherRefundableTaxOffsets
    {
        public int T11OtherRefundableTaxOffsetsId { get; set; }
        public int TaxOffSet { get; set; }
        public string Code { get; set; }



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

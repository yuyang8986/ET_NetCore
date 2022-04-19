using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T10OtherNonRefundableTaxOffsets
    {
        public int T10OtherNonRefundableTaxOffsetsId { get; set; }
        public int TaxOffset { get; set; }
        public string ActionCode { get; set; }//H,I



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

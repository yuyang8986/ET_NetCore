using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class OtherItemTypeOtherItemForm
    {
        public OtherItemType OtherItemType { get; set; }
        public int OtherItemTypeId { get; set; }

        public OtherItemTypeForm OtherItemTypeForm { get; set; }
        public int OtherItemTypeFormId { get; set; }
    }
}

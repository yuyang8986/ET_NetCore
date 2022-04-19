using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class DeductionTypeDeductionTypeForm
    {
        public DeductionType DeductionType { get; set; }
        public int DeductionTypeId { get; set; }

        public DeductionTypeForm DeductionTypeForm { get; set; }
        public int DeductionTypeFormId { get; set; }
    }
}

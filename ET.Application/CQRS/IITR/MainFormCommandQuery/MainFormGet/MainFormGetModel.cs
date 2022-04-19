using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.LodgementAggregate;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormGet
{
    public class MainFormGetModel
    {
        public int Id { get; set; }
        public int LodgementId { get; set; }

        public BasicDetailsForm BasicDetailsForm { get; set; } 
        public IncomeDetailsForm IncomeDetailsForm { get; set; }
        public IncomeTypeForm IncomeTypeForm { get; set; }
        public DeductionTypeForm DeductionTypeForm { get; set; }
        public DeductionDetailsForm DeductionDetailsForm { get; set; }
        public OtherItemTypeForm OtherItemTypeForm { get; set; }
        public OtherItemDetailsForm OtherItemDetailsForm { get; set; }
        public IITRLodgement IITRLodgement { get; set; } 
    }
}

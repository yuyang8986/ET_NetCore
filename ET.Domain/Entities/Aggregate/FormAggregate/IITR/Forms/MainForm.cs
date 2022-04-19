using ET.Domain.Entities.Aggregate.LodgementAggregate;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class MainForm:FormBase
    {
        //Navigation Property
        public BasicDetailsForm BasicDetailsForm { get; set; } // 1 to 0...1
      

        public IncomeDetailsForm IncomeDetailsForm { get; set; }// 1 to 0...1
       

        public IncomeTypeForm IncomeTypeForm { get; set; }// 1 to 0...1
   

        public DeductionTypeForm DeductionTypeForm { get; set; }// 1 to 0...1
        

        public DeductionDetailsForm DeductionDetailsForm { get; set; }// 1 to 0...1
        

        public OtherItemTypeForm OtherItemTypeForm { get; set; }// 1 to 0...1
        

        public OtherItemDetailsForm OtherItemDetailsForm { get; set; }// 1 to 0...1


        public IITRLodgement IITRLodgement { get; set; } // 1 to 1 

     
        [JsonIgnore]
        public int? LodgementId { get; set; } //to link to the lodement when create lodgement

        public MainForm(){}

        public MainForm(bool isReviewed) : base(isReviewed)
        {
        }
    }
}

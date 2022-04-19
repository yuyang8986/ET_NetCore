using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class BasicDetailsForm : FormBase
    {

        public BasicDetailsForm(int mainFormId)
        {
            MainFormId = mainFormId;
        }

        public BasicDetailsForm(bool isReviewed):base(isReviewed)
        {
            
        }

        public bool IsLastITRInAu { get; set; }
        public bool IsAustralianCitizenship { get; set; }
        public bool IsLiveFullYearInAu { get; set; }
        public int BSB { get; set; }
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public bool HasHELPOrTSL { get; set; }
        public bool HasSFSS { get; set; }
        public bool HasOtherTaxDebt { get; set; }//such as child support debt or Family Tax Assistance

        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }
    }
}

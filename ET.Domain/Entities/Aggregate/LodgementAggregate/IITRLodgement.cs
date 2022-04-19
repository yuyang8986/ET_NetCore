using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.LodgementAggregate
{
    //IITR lodgement
    public class IITRLodgement
    {
        public IITRLodgement()
        {
            LodgementStatus = Types.LodgementStatus.NotStarted;
        }

        public IITRLodgement(string status)
        {
            LodgementStatus = status;
        }

        public IITRLodgement(int financialYear, string status):this(status)
        {
            FinancialYear = new FinancialYear(financialYear);
        }

        [JsonIgnore]
        public int IITRLodgementId { get; set; }

        public string LodgementStatus { get; set; } 

        //Navigation Properties
        [JsonIgnore]
        public Individual Individual { get; set; } //must has a individual
        public int IndividualId { get; set; }//FK

        [JsonIgnore]
        public MainForm MainForm { get; set; } //must has
        public int MainFormId { get; set; }

        public FinancialYear FinancialYear { get; set; } //must have
        [JsonIgnore]
        public int FinancialYearId { get; set; }


        private bool IsReadyToLodge()
        {
            if (LodgementStatus == Types.LodgementStatus.Pending || LodgementStatus == Types.LodgementStatus.Completed)
                return false;

            return true;
        }
    }
}
using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class DeductionDetailsForm : FormBase
    {
        public DeductionDetailsForm()
        {
            DeductionTypeDetails = new HashSet<DeductionTypeDetail>();
        }

        public DeductionDetailsForm(int mainFormId):this()
        {
            MainFormId = mainFormId;
        }

        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }

        public ICollection<DeductionTypeDetail> DeductionTypeDetails { get; set; }
    }
}

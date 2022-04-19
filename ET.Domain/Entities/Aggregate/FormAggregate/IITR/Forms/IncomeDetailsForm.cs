using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class IncomeDetailsForm : FormBase
    {
        public IncomeDetailsForm()
        {
            
        }

        public IncomeDetailsForm(int mainFormId)
        {
            MainFormId = mainFormId;
        }


        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }

        public ICollection<IncomeTypeDetail> IncomeTypeDetails { get; set; }
    }
}

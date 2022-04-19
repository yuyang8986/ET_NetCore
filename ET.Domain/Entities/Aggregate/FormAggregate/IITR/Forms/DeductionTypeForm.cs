using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class DeductionTypeForm : FormBase
    {

        public DeductionTypeForm(int mainFormId)
        {
            MainFormId = mainFormId;
            DeductionTypeDeductionTypeForms = new HashSet<DeductionTypeDeductionTypeForm>();
        }
        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }
      
        public ICollection<DeductionTypeDeductionTypeForm> DeductionTypeDeductionTypeForms { get; private set; }
    }
}

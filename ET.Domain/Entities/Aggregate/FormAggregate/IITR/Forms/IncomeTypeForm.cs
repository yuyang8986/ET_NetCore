using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class IncomeTypeForm : FormBase
    {
        public IncomeTypeForm(int mainFormId)
        {
            MainFormId = mainFormId;
            IncomeTypeIncomeTypeForms = new HashSet<IncomeTypeIncomeTypeForm>();
        }

        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }
   
        public ICollection<IncomeTypeIncomeTypeForm> IncomeTypeIncomeTypeForms { get; set; }
    }
}

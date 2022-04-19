using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms
{
    public class OtherItemTypeForm : FormBase
    {
        public OtherItemTypeForm(int mainFormId)
        {
            MainFormId = mainFormId;
            OtherItemTypeOtherItemForms = new HashSet<OtherItemTypeOtherItemForm>();
        }

        //NP
        [JsonIgnore]
        public MainForm MainForm { get; set; } //must have a main form
        public int MainFormId { get; set; }
       
        public ICollection<OtherItemTypeOtherItemForm> OtherItemTypeOtherItemForms { get; private set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class OtherItemType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OtherItemTypeId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }



        public OtherItemType()
        {
            OtherItemTypeOtherItemForms = new HashSet<OtherItemTypeOtherItemForm>();
            OtherItemTypeDetails = new HashSet<OtherItemTypeDetail>();
        }
        //NP
        [JsonIgnore]
        public ICollection<OtherItemTypeDetail> OtherItemTypeDetails { get; private set; }
        [JsonIgnore]
        public ICollection<OtherItemTypeOtherItemForm> OtherItemTypeOtherItemForms { get; private set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class DeductionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeductionTypeId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }


        //NP


        public DeductionType()
        {
            DeductionTypeDeductionTypeForms = new HashSet<DeductionTypeDeductionTypeForm>();
            OccupationCategoryDeductionTypes = new HashSet<OccupationCategoryDeductionType>();
            DeductionTypeDetails = new HashSet<DeductionTypeDetail>();
        }

        [JsonIgnore]
        public ICollection<DeductionTypeDetail> DeductionTypeDetails { get; private set; } //1 to 1
       
        [JsonIgnore]
        public ICollection<DeductionTypeDeductionTypeForm> DeductionTypeDeductionTypeForms { get; private set; }

        [JsonIgnore]
        public ICollection<OccupationCategoryDeductionType> OccupationCategoryDeductionTypes { get; private set; }
    }
}

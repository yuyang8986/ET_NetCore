using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class IncomeType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IncomeTypeId { get; set; }
        public string Description  { get; set; }
        public string Code { get; set; }




        public IncomeType()
        {
            IncomeTypeIncomeTypeForms = new HashSet<IncomeTypeIncomeTypeForm>();
            OccupationCategoryIncomeTypes = new HashSet<OccupationCategoryIncomeType>();
            IncomeTypeDetails = new HashSet<IncomeTypeDetail>();
        }

        //NP
        [JsonIgnore]
        public ICollection<IncomeTypeDetail> IncomeTypeDetails { get; private set; } 
        [JsonIgnore]
        public ICollection<IncomeTypeIncomeTypeForm> IncomeTypeIncomeTypeForms { get; private set; } //for many to many purpose
        [JsonIgnore]
        public ICollection<OccupationCategoryIncomeType> OccupationCategoryIncomeTypes { get; private set; } //for many to many purpose
    }
}

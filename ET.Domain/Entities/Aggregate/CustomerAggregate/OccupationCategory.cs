using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    public class OccupationCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OccupationCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public OccupationCategory()
        {
            OccupationCategoryIncomeTypes = new HashSet<OccupationCategoryIncomeType>();
            OccupationCategoryDeductionTypes = new HashSet<OccupationCategoryDeductionType>();
        }

        //np
       
        public ICollection<OccupationCategoryIncomeType> OccupationCategoryIncomeTypes { get; private set; }
    
        public ICollection<OccupationCategoryDeductionType> OccupationCategoryDeductionTypes { get; private set; }
    }
}

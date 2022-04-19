using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    public class OccupationCategoryIncomeType
    {
        [JsonIgnore]
        public OccupationCategory OccupationCategory { get; set; }
        [JsonIgnore]
        public int OccupationCategoryId { get; set; }

        public IncomeType IncomeType { get; set; }
        [JsonIgnore]
        public int IncomeTypeId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    public class OccupationCategoryDeductionType
    {
        [JsonIgnore]
        public OccupationCategory OccupationCategory { get; set; }
        [JsonIgnore]
        public int OccupationCategoryId { get; set; }

        public DeductionType DeductionType { get; set; }
        [JsonIgnore]
        public int DeductionTypeId { get; set; }
    }
}

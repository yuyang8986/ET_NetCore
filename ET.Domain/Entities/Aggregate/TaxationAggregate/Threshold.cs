using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate
{
    public class Threshold
    {
        public int ThresholdId { get; set; }



        public int Min { get; set; }
        public int Max { get; set; }

        //NP
        [JsonIgnore]
        public TaxCompliance TaxCompliance { get; set; } // must have a tax compliance
        public int TaxComplianceId { get; set; }
    }
}
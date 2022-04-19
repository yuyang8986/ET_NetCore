using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate
{
    //can be a threshold, can be tax rate, can be others, a tax ruling in one year
    public class TaxCompliance
    {
        public int TaxComplianceId { get; set; }
        public string Description { get; set; } //eg. this is for individual tax rate in 2018
        public string Code { get; set; }



        //NP
        [JsonIgnore]
        public FinancialYear FinancialYear { get; set; } // must has
        public int FinancialYearId { get; set; }

        public Threshold Threshold { get; set; }  //1 to 0...1

    }
}

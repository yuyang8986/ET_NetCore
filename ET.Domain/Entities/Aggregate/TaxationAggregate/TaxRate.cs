using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate
{
    public class TaxRate
    {
        public int TaxRateId { get; set; }
        public double Rate { get; set; }
        public string Code { get; set; } //Individual, Business, SMSF



        //NP
        [JsonIgnore]
        public FinancialYear FinancialYear { get; set; }
        public int FinancialYearId { get; set; }//must has a financial year
    }
}
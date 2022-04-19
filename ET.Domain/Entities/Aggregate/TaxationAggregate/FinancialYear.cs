using System;
using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate
{
    public class FinancialYear
    {
        [JsonIgnore]
        public int FinancialYearId { get; set; }

        public int Year { get; set; }

        public FinancialYear()
        {
            
        }

        public FinancialYear(int financialYear)
        {
            Year = financialYear;
            TaxCompliances = new HashSet<TaxCompliance>();
            TaxRates = new HashSet<TaxRate>();
            Lodgements = new HashSet<IITRLodgement>();
        }

        //NP
        [JsonIgnore]
        public ICollection<TaxCompliance> TaxCompliances { get; private set; }
        [JsonIgnore]
        public ICollection<TaxRate> TaxRates { get; private set; } // 1 to 1..N

        [JsonIgnore]
        public ICollection<IITRLodgement> Lodgements { get; private set; }
    }
}
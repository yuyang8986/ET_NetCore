using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class OtherItemTypeDetail
    {
        public int OtherItemTypeDetailId { get; set; }

        [JsonIgnore]
        public OtherItemType OtherItemType { get; set; }
        public int OtherItemTypeId { get; set; } // must has a income type



        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public A1Under18 A1Under18 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public A2PartYearTaxFreeThreshold A2PartYearTaxFreeThreshold { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public A3SuperCoContribution A3SuperCoContribution { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public A4WorkingHolidayMakerNetIncome A4WorkingHolidayMakerNetIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DependencyChildren DependencyChildren { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IncomeTests IncomeTests { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public M1MedicareLevyReductionOrExemption M1MedicareLevyReductionOrExemption { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public M2MedicareLevSurcharge M2MedicareLevSurcharge { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrivateHealthInsurancePolicyDetails> PrivateHealthInsurancePolicyDetails { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SpouseDetails SpouseDetails { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T10OtherNonRefundableTaxOffsets T10OtherNonRefundableTaxOffsets { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T11OtherRefundableTaxOffsets T11OtherRefundableTaxOffsets { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T1SeniorsAndPensioners T1SeniorsAndPensioners { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T2AustralianSuperannuationIncomeStream T2AustralianSuperannuationIncomeStream { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T3SuperannuationContributionsOnBehalfOfYourSpouse T3SuperannuationContributionsOnBehalfOfYourSpouse { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T4ZoneOrOverseasForces T4ZoneOrOverseasForces { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T6Dependent T6Dependent { get; set; }
    }
}

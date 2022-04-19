using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class PrivateHealthInsurancePolicyDetails
    {
        public int PrivateHealthInsurancePolicyDetailsId { get; set; }
        public string FamilyStatus { get; set; }
        public bool IsThisForSpouseOrSelf { get; set; } // true is spouse

        public string HealthInsurerCode { get; set; }
        public int MembershipNumber { get; set; }
        public int PremiumsEligibleForAustralianGovernmentRebate { get; set; }
        public int AustralianGovernmentRebate { get; set; }
        public string BenefitCode { get; set; }



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

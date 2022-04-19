using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class PartnershipsAndTrusts
    {
        public int PartnershipsAndTrustsId { get; set; }
        public int DistributionFromPartnerships { get; set; }
        public bool IsDistributionProfit { get; set; }//false = loss
        public int DistributionFromTrusts { get; set; }
        public string DistributionFromTrustsCode { get; set; }
        public int LandCareOperationsAndDeductionForDeclineInValue { get; set; }//Landcare operations and deduction for decline in value of water facility, fencing asset and fodder storage asset
        public int OtherDeductionsRelatedToDistribution { get; set; }
        public string OtherDeductionCode { get; set; }
        public int NonPPDistribution { get; set; }//Distribution from partnerships relating to financial investments, less foreign income
        public bool IsNonPPDistributionProfit { get; set; }
        public int NonPPShare { get; set; }
        public bool IsNonPPShareProfit { get; set; }
        public int NonPPOtherDistribution { get; set; }
        public bool IsNonPPOtherDistributionProfit { get; set; }
        public int NonPPShareOfNetIncomeFromTrustsLessOthers { get; set; }
        public bool IsNonPPShareOfNetIncomeFromTrustsLessOthersProfit { get; set; }
        public int DistributionFromTrustsLessNetCGAndFI { get; set; }
        public bool IsDistributionFromTrustsLessNetCGAndFIProfit { get; set; }
        public string DistributionFromTrustsLessNetCGAndFICode { get; set; }
        //TODO




        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

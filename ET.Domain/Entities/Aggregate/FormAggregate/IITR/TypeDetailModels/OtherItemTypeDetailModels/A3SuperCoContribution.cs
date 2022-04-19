using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class A3SuperCoContribution
    {
        public int A3SuperCoContributionId { get; set; }
        public int IncomeFromInvestmentPartnershipAndOtherSourcesAmount { get; set; }
        public string SuperannuationCoContributionsIndicator { get; set; }
        public int OtherIncomeFromEmploymentAndBusiness { get; set; }
        public int OtherDeductionsFromBusinessIncome { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }  
    }
}

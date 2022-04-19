using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D12PersonalSuperannuationContributions
    {
        public int D12PersonalSuperannuationContributionsId { get; set; }
        public bool IsConfirmClaimDeductionAndReceivedConfirmationFromSuperFund { get; set; }
        public string NameOfFund { get; set; }
        public int AccountNumber { get; set; }
        public int DeductionAmount { get; set; }
        public string SuperFundABN { get; set; }
        public string SuperFundTFN { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

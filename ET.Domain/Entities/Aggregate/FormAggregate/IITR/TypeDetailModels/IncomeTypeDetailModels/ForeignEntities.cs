using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class ForeignEntities
    {
        public int ForeignEntitiesId { get; set; }
        public bool HasDirectOrInDirectInterestInCFC { get; set; }
        public int CFCIncome { get; set; }
        public bool HasCausedTransferOfPropertyOrServiceToNonResidentTrustEstate { get; set; }
        public int TransferTrustIncome { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

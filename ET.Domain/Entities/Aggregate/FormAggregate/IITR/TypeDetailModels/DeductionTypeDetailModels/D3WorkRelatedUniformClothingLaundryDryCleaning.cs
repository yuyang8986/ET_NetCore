using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D3WorkRelatedUniformClothingLaundryDryCleaning
    {
        public int D3WorkRelatedUniformClothingLaundryDryCleaningId { get; set; }
        public int TotalPaid { get; set; }
        public string TypeOfClothing { get; set; }//C,N,S,P
        public string DescriptionForAllClothing { get; set; }
        public bool HasReceipt { get; set; }
        public bool IsProtectiveClothingRequiredForWork { get; set; }
        public bool HasBusinessLogoIfClaimUniform { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

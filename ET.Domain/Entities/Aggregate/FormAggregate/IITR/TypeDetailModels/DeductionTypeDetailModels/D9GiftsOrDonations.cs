using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class D9GiftsOrDonations
    {
        public int D9GiftsOrDonationsId { get; set; }
        public int Amount { get; set; }
        public string NameOfCharities { get; set; }
        public bool HasReceipt { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

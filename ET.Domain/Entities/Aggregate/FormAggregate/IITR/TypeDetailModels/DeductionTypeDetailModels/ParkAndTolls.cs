using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class ParkAndTolls
    {
        public int ParkAndTollsId { get; set; }
        public int TotalCostOfParking { get; set; }
        public int TotalCostOfTolls { get; set; }
        public bool HasReceipts { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

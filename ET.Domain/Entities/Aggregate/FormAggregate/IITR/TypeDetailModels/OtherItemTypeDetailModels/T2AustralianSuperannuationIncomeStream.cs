using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T2AustralianSuperannuationIncomeStream
    {
        public int T2AustralianSuperannuationIncomeStreamId { get; set; }
        public int Amount { get; set; }



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

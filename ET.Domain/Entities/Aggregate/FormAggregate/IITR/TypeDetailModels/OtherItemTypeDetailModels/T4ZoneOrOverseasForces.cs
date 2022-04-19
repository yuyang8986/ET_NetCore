using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T4ZoneOrOverseasForces
    {
        public int T4ZoneOrOverseasForcesId { get; set; }
        public int Amount { get; set; }
        public bool HasLivedInThisAreaMoreThan182Days { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

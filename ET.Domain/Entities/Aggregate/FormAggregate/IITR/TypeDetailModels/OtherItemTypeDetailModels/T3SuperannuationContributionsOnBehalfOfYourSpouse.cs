using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T3SuperannuationContributionsOnBehalfOfYourSpouse
    {
        public int T3SuperannuationContributionsOnBehalfOfYourSpouseId { get; set; }
        public int ContributionPaid { get; set; }
        public int ContributionsOnBehalfOfSpouseTaxOffset { get; set; }



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

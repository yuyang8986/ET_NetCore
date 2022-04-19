using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class T1SeniorsAndPensioners //(includes self-funded retirees
    {
        public int T1SeniorsAndPensionersId { get; set; }
        public string SeniorTaxOffsetMaritalStatusCode { get; set; } //ABCDE
        public string VeteransOrSpouseOfVeterans { get; set; } //VXW




        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

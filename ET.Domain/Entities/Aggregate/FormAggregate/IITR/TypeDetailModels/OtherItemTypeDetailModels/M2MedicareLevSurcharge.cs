using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class M2MedicareLevSurcharge
    {
        public int M2MedicareLevSurchargeId { get; set; }
        public bool HasPrivateHospitalCoverForWholeYear { get; set; } //For the whole period from 1 July 2017 to 30 June 2018, did you and all your dependants (including your spouse if you had one) have private hospital cover?
        public bool IsIncomeBelow90000OrFamilyIncomeBelow180000 { get; set; }//Was your income below $90000 OR your family income below $180000 (plus $1500 per child excluding the first)?



        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }
    }
}

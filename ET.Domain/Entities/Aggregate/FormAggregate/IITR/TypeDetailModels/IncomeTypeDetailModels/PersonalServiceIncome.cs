using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
   public class PersonalServiceIncome
    {
        public int PersonalServiceIncomeId { get; set; }
        public int TaxWithHeldVoluntaryAgreement { get; set; }
        public int TaxWithHeldABNNotQuoted { get; set; }
        public int TaxWithHeldLabourHireOrOtherSpecifiedPayments { get; set; }



        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }

    }
}

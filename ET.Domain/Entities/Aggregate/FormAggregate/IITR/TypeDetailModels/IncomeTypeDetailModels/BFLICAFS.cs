using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class BFLICAFS //Bonuses From Life Insurance Companies And Friendly Societies
    {
        public int BFLICAFSId { get; set; }
        public int BonusFromLifeInsuranceCompaniesAndFriendlySocieties { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class NetFarmManagementDepositOrRepayments
    {
        public int NetFarmManagementDepositOrRepaymentsId { get; set; }
        public int DeductibleDeposits { get; set; }
        public int EarlyRepaymentsNaturalDisasterAndDrought { get; set; }
        public int OtherRepayment { get; set; }
        public int NetFarmManagementDepositsOrRepayments { get; set; }
        public bool IsNetIncomeEqualisationProfit { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P8BusinessIncomeAndExpensesFarming
    {
        //Income
        public int P8BusinessIncomeAndExpensesFarmingId { get; set; }
        public int GrossABNNotQuoted { get; set; }
        public int GrossVoluntaryAgreement { get; set; }
        public int GrossLabourHireOrOther { get; set; }
        public int AssessableGovernmentIndustryPayment { get; set; }
        public string AssessableGovernmentIndustryPaymentActionCode { get; set; }
        public int OtherBusinessIncome { get; set; }
        public bool IsOtherBusinessIncomeProfit { get; set; }

        //Expense
        public int OpeningStock { get; set; }
        public int PurchasesAndOtherCosts { get; set; }
        public int ClosingStock { get; set; }
        public string ClosingStockCode { get; set; }
        public int ContractorSubContractorAndCommissionExpenses { get; set; }
        public int BadDebts { get; set; }
        public int LeaseExpenses { get; set; }
        public int RentExpenses { get; set; }
        public int InterestExpensesOversea { get; set; }
        public int DepreciationExpenses { get; set; }
        public int MotorVehicleExpenses { get; set; }
        public string MotorVehicleExpenseActionCode { get; set; }
        public int RepairsAndMaintenance { get; set; }
        public int AllOtherExpenses { get; set; }

        //Reconciliation
        public int Section40880Deduction { get; set; }
        public int BusinessDeductionForProjectPool { get; set; }
        public int LandCareOperationsAndBusinessDeductionForDeclineInValueOfWaterFacility { get; set; }
        public int IncomeReconciliationAdjustments { get; set; }
        public bool IsIncomeReconciliationAdjustmentsProfit { get; set; }
        public int ExpenseReconAdjustment { get; set; }
        public bool IsExpenseReconAdjustmentProfit { get; set; }


        //Prior Year Amount
        public int DeferredNonCommercialLossesFromAPriorYear { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

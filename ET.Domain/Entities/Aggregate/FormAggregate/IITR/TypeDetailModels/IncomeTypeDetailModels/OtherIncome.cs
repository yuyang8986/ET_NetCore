using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class OtherIncome
    {
        public int OtherIncomeId { get; set; }
        public int TaxWithHeldLumpSumPaymentInArrears { get; set; }
        public int TaxableProfessionalIncome { get; set; }

        //source
        public string OneActionCode { get; set; }//S, N
        public int AssessableBalancingAdjustmentForLowValuePoolDeductionRelationToRentalProperty { get; set; }
        public int AssessableBalancingAdjustmentForLowValuePoolDeductionRelationToFinancialInvestments { get; set; }
        public int OtherCategoryOneIncome { get; set; }
        public int OtherCategoryTwoIncomeATOInterest { get; set; }
        public int OtherCategoryThreeAmount { get; set; }
        public string OtherCategoryThreeDescription { get; set; }
        public string OtherCategoryThreeCode { get; set; } //S,N
        public int IncomeFromFinancialInvestmentNotIncludedAtAnotherLabel { get; set; }
        public int OtherCategory3Income { get; set; }



        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

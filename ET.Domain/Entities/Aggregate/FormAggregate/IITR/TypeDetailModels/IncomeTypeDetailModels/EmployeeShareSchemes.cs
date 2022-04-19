using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
     public class EmployeeShareSchemes
    {
        public int EmployeeShareSchemesId { get; set; }
        public int DFTUFSEligibleForReductionAmount { get; set; }//Discount from taxed upfront schemes - eligible for reduction
        public int DFTUFSNotEligibleForReductionAmount { get; set; }//Discount from taxed upfront schemes - not eligible for reduction
        public int DiscountFromDeferralSchemes { get; set; }
        public int DiscountESSIntBef172009 { get; set; }//Discount on ESS Interests acquired before 01/07/2009 and ‘cessation time’ occurred during financial year
        public int TotalAssesableDiscountAmout { get; set; }
        public int ESSTFNAmountsWithHeldFromDiscounts { get; set; }
        public int ForeignSourceDiscounts { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }

    }
}

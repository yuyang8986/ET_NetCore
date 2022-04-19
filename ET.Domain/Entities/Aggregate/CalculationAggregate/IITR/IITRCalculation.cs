using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.CalculationAggregate.IITR
{
    public class IITRCalculation:IIITRCalculation
    {
        public IITRCalculation(MainForm mainform, TaxRate taxRate)
        {
            Mainform = mainform;
            TaxRate = taxRate;
            GrossIncome = SetGrossIncome();
            GrossDeduction = SetGrossExpense();
            GrossTaxOffset = SetTotalTaxOffsets();
            OtherTypeItemOffset = SetOtherTypeItemOffset();
        }
        
        public MainForm Mainform { get; }
        public TaxRate TaxRate { get; }
      

        public double GrossIncome {get;set;}
        public double GrossDeduction { get; set; }
        public double GrossTaxOffset { get; set; }
        public double OtherTypeItemOffset { get; set; }

        public double SetGrossIncome()
        {
            List<IncomeTypeDetail> incomeTypeDetails = Mainform.IncomeDetailsForm.IncomeTypeDetails.ToList();

            if (incomeTypeDetails.Count == 0) return 0;

            double totalGrossIncome = incomeTypeDetails.Select(s => s.TotalAmount).Sum();

            return totalGrossIncome;
        }

        public double SetGrossExpense()
        {
            List<DeductionTypeDetail> deductionTypeDetails =
                Mainform.DeductionDetailsForm.DeductionTypeDetails.ToList();
            if (deductionTypeDetails.Count == 0) return 0;

            double totalDeduction = deductionTypeDetails.Select(s => s.TotalAmount).Sum();
            return totalDeduction;
        }

        public double SetTotalTaxOffsets()
        {
            List<IncomeTypeDetail> incomeTypeDetails = Mainform.IncomeDetailsForm.IncomeTypeDetails.ToList();

            double totalGrossOffset = incomeTypeDetails.Select(s => s.TotalTaxOffsetAmount).Sum();

            return totalGrossOffset;
        }

        public double SetOtherTypeItemOffset()
        {
            List<OtherItemTypeDetail> otherItemTypeDetails =
                Mainform.OtherItemDetailsForm.OtherItemTypeDetails.ToList();

            //handle other type item impact on tax offset

            return 0; //0 is placeholder
        }

        public double CalculateTax()
        {
            return (GrossIncome - GrossDeduction) * TaxRate.Rate - GrossTaxOffset;
        }
    }
}

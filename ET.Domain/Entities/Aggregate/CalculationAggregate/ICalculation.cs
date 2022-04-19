using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;

namespace ET.Domain.Entities.Aggregate.CalculationAggregate
{
    public interface ICalculation
    {
        double GrossIncome { get; set; }
        double GrossDeduction { get; set; }
        double GrossTaxOffset { get; set; }
        double SetGrossIncome();
        double SetGrossExpense();
        double SetTotalTaxOffsets();
        double CalculateTax();
    }
}

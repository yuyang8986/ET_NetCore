using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;

namespace ET.Domain.Entities.Aggregate.TaxationAggregate.IITR
{
    public class IncomeTypeIncomeTypeForm
    {
        public IncomeType IncomeType { get; set; }
        public int IncomeTypeId { get; set; }

        public IncomeTypeForm IncomeTypeForm { get; set; }
        public int IncomeTypeFormId { get; set; }
    }
}

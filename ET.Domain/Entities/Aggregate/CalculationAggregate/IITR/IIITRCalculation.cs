using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.TaxationAggregate;

namespace ET.Domain.Entities.Aggregate.CalculationAggregate.IITR
{
    interface IIITRCalculation:ICalculation
    {
        MainForm Mainform { get; }
        TaxRate TaxRate { get; }
        double OtherTypeItemOffset { get; set; }
        double SetOtherTypeItemOffset();
    }
}

using System;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
   public class ETP // Employment Termination Payments
    {
        public int ETPId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string ABN { get; set; }
        public int TaxWithHeld { get; set; }
        public int TaxableComponent { get; set; }
        public string Code { get; set; }


        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

using System;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class ASLSP // Australian Superannuation Lump Sum Payments
    {
        public int ASLSPId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string PayerABN { get; set; }
        public int TaxWithHeld { get; set; }
        public int TaxableComponentTaxedElement { get; set; }
        public int TaxableComponentUntaxedElement { get; set; }
        public string Desciption { get; set; } //N or M

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }

    }
}

using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class AAASIS //Australian Annuities And Superannuation Income Streams
    {
        public int AAASISId { get; set; }
        public int TaxWithHeld { get; set; }
        public int TaxableComponentTaxed { get; set; }
        public int TaxableComponentUnTaxed{ get; set; }
        public int AssessableAmountFromCappedDefinedBenefitIncomeStream { get; set; }
        public int LumpSumInArrearsTaxed { get; set; }
        public int LumpSumInArrearsUnTaxed { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

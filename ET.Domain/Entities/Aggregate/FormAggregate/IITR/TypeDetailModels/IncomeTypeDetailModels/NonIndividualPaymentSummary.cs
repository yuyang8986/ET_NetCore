using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class NonIndividualPaymentSummary
    {
        public int NonIndividualPaymentSummaryId { get; set; }
        public string NatureOfIncomeType { get; set; } //Business Or PersonalService
        public string PayerABNOrWithHoldingPayerNumber { get; set; }
        public int TaxWithheld { get; set; }
        public int GrossPayment { get; set; }
        public string Type { get; set; }
        public string PayerName { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

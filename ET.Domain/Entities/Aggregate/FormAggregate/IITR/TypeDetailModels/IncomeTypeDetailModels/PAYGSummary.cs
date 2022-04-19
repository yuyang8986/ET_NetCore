using System.ComponentModel.DataAnnotations;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class PAYGSummary
    {
        public int PAYGSummaryId { get; set; }

        [Required]
        public string ABN { get; set; }

        [Required]
        public string PayerName { get; set; }
        public string Note { get; set; }

        [Required]
        public int TotalTaxWithHeld { get; set; }

        [Required]
        public int GrossPayment { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

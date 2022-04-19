using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels
{
    public class HomeOfficeExpense
    {
        public int HomeOfficeExpenseId { get; set; }
        public string Type { get; set; }
        public int WeeksWorkedForYear { get; set; }// 48 normally
        public int AverageNumberOfHoursWorkedPerWeekAtHome { get; set; }

        //Telephone
        public int PercentageOfTelephoneBillsToWork { get; set; }
        public string TypeOfEvidenceForTelephoneBills { get; set; }
        public int TelephoneCostForWorkTotal { get; set; }

        //Other Depreciation over $300
        public int PercentageOfOtherDepreciationToWork { get; set; }
        public string TypeOfEvidenceForOtherDepreciation { get; set; }
        public int OtherDepreciationForWorkTotal { get; set; }

        //Printing, Postage, Stationery
        public int PercentageOfOtherPrintingPostageStationery { get; set; }
        public string TypeOfEvidenceForPrintingPostageStationery { get; set; }
        public int PrintingPostageStationeryForWorkTotal { get; set; }

        public DeductionTypeDetail DeductionTypeDetail { get; set; }
        public int DeductionTypeDetailId { get; set; }
    }
}

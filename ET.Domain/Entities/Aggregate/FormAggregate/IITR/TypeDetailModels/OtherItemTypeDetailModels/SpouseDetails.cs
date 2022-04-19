using System;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels
{
    public class SpouseDetails
    {
        public int SpouseDetailsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherGivenNames { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public bool HasSpouseForFullFY { get; set; }
        public int SpouseTaxableIncome { get; set; }
        public int TotalReportableFringeBenefitsAmount { get; set; }
        public int FBUnder57A { get; set; }
        public int FBNotUnder57A { get; set; }
        public int GvernmentPensionsAndAllowance { get; set; }
        public int ExemptPensionIncome { get; set; }
        public int ReportableSuperContribution { get; set; }
        public int TaxFreeGovernmentPension { get; set; }
        public int NetInvestmentLoss { get; set; }
        public int ChildSupportSpousePaid { get; set; }


        public OtherItemTypeDetail OtherItemTypeDetail { get; set; }
        public int OtherItemTypeDetailId { get; set; }

    }
}

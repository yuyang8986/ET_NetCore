using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;

namespace ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels
{
    public class P1PersonalServicesIncome
    {
        //Part A
        public int P1PersonalServicesIncomeId { get; set; }
        public bool IsSatisfyResultTest { get; set; }
        public bool HasReceivedPSIDeterminationForceForWholePeriod { get; set; }
        public bool IsPSIMoreThanEightyPercentOfAllIncome { get; set; }
        public bool IsSatisfyUnRelatedClientsTest { get; set; }
        public bool IsSatisfyEmploymentTest { get; set; }
        public bool IsSatisfyBusinessPremisesTest { get; set; }


        //Part B
        public int PSIVoluntaryAgreement { get; set; }
        public int PSDIABNNotQuoted { get; set; }
        public int PSILabourHireOrOtherSpecifiedPayments { get; set; }
        public int PSIOther { get; set; }
        public int DeductionforPaymentsToAssociatesForPrincipalWork { get; set; }
        public int TotalAmountOfOtherDeductionsAgainstPSI { get; set; }

        public ICollection<NonIndividualPaymentSummary> NonIndividualPaymentSummaries { get; set; }

        public IncomeTypeDetail IncomeTypeDetail { get; set; }
        public int IncomeTypeDetailId { get; set; }
    }
}

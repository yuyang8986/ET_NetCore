using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels;
using Newtonsoft.Json;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand
{
    public struct IncomeTypeDetailsFormUpdateDto
    {
        [Required]
        public int IncomeTypeDetailId { get; set; }
        [Required]
        public int IncomeTypeId { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        public double TotalTaxOffsetAmount { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AAASIS Aaasis { get; set; }//Australian Annuities And Superannuation Income Streams

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AGA Aga { get; set; }//Australian Government Allowance

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AGP Agp { get; set; }//australian government pension

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Allowance> Allowances { get; set; }//eg, allowance income type has 1 to many Allowances

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public APSI Apsi { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ASLSP> Aslsps { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public BankInterest BankInterest { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public BFLICAFS Bflicafs { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CapitalGainOrLosses CapitalGainOrLosses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DeferredNonCommercialBusinessLosses DeferredNonCommercialBusinessLosses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dividends Dividends { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ELSP> Elsps { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EmployeeShareSchemes EmployeeShareSchemes { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ETP> Etps { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FMISI Fmisi { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ForeignEntities ForeignEntities { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ForeignSourceIncome ForeignSourceIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public NetFarmManagementDepositOrRepayments NetFarmManagementDepositOrRepayments { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public NetIncomeOrLossFromBusiness NetIncomeOrLossFromBusiness { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public OtherIncome OtherIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PartnershipsAndTrusts PartnershipsAndTrusts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PAYGSummary> PaygSummaries { get; set; }//eg, salary income type has 1 to many PAYGs

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PersonalServiceIncome PersonalServiceIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Rent Rent { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P1PersonalServicesIncome P1PersonalServicesIncome { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P2DescriptionOfMainBusinessOrProfessionalActivity P2DescriptionOfMainBusinessOrProfessionalActivity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P4StatusOfBusiness P4StatusOfBusiness { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P5BusinessNameOfMainBusinessAndABN P5BusinessNameOfMainBusinessAndAbn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P7GSTByInternet P7GstByInternet { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P8BusinessIncomeAndExpensesFarming P8BusinessIncomeAndExpensesFarming { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P8BusinessIncomeAndExpensesNonFarming P8BusinessIncomeAndExpensesNonFarming { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P9BusinessLossActivity P9BusinessLossActivity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P10SmallBusinessEntityDepreciatingAssets P10SmallBusinessEntityDepreciatingAssets { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P11TradeDebtors P11TradeDebtors { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P12TradeCreditors P12TradeCreditors { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P13TotalSalaryAndWageExpenses P13TotalSalaryAndWageExpenses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P14PaymentsToAssociatedPersons P14PaymentsToAssociatedPersons { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P15IntangibleDepreciatingAssetsFirstDeducted P15IntangibleDepreciatingAssetsFirstDeducted { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P16OtherDepreciatingAssetsFirstDeducted P16OtherDepreciatingAssetsFirstDeducted { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P17TerminationValueOfIntangibleDepreciatingAsset P17TerminationValueOfIntangibleDepreciatingAsset { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P18TerminationValueOfOtherDepreciatingAssets P18TerminationValueOfOtherDepreciatingAssets { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public P19TradingStockElection P19TradingStockElection { get; set; }
    }
}

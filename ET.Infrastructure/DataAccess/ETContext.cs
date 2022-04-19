using System.Threading;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.Forms;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.IncomeTypeDetailModels;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using ET.Domain.Entities.Auth;
using ET.Infrastructure.Configurations;
using ET.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ET.Infrastructure.DataAccess
{
    //to allow user int for all
    public class ETContext:IdentityDbContext<User, Role,int,IdentityUserClaim<int>,
        UserRole,IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ETContext(DbContextOptions<ETContext> options):base(options){}

        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OccupationCategory> OccupationCategories { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<IITRLodgement> IITRLodgements { get; set; }

        //Main form contents
        public DbSet<MainForm> MainForms { get; set; }
        public DbSet<BasicDetailsForm> BasicDetailsForms { get; set; }
        public DbSet<IncomeTypeForm> IncomeTypeForms { get; set; }
        public DbSet<IncomeDetailsForm> IncomeDetailsForms { get; set; }
        public DbSet<DeductionTypeForm> DeductionTypeForms { get; set; }
        public DbSet<DeductionDetailsForm> DeductionDetailsForms { get; set; }
        public DbSet<OtherItemTypeForm> OtherItemTypeForms { get; set; }
        public DbSet<OtherItemDetailsForm> OtherItemDetailsForms { get; set; }

        //Many to Many join tables
        public DbSet<IncomeTypeIncomeTypeForm> IncomeTypeIncomeTypeForms { get; set; }
        public DbSet<DeductionTypeDeductionTypeForm> DeductionTypeDeductionTypeForms { get; set; }
        public DbSet<OtherItemTypeOtherItemForm> OtherItemTypeOtherItemTypeForms { get; set; }
        public DbSet<OccupationCategoryDeductionType> OccupationCategoryDeductionTypes { get; set; }
        public DbSet<OccupationCategoryIncomeType> OccupationCategoryIncomeTypes { get; set; }

        //Tax Related
        public DbSet<TaxCompliance> TaxCompliances { get; set; }
        public DbSet<FinancialYear> FinancialYears { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<Threshold> Thresholds { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<IncomeTypeDetail> IncomeTypeDetails { get; set; }
        public DbSet<DeductionType> DeductionTypes { get; set; }
        public DbSet<DeductionTypeDetail> DeductionTypeDetails { get; set; }
        public DbSet<OtherItemType> OtherItemTypes { get; set; }
        public DbSet<OtherItemTypeDetail> OtherItemTypeDetails { get; set; }

        //Income Type Detail Items
        public DbSet<AAASIS> Aaasiss { get; set; }
        public DbSet<AGA> Agas { get; set; }
        public DbSet<AGP> Agps { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<APSI> Apsis { get; set; }
        public DbSet<ASLSP> Aslsps { get; set; }
        public DbSet<BankInterest> BankInterests { get; set; }
        public DbSet<BFLICAFS> Bflicafss { get; set; }
        public DbSet<CapitalGainOrLosses> CapitalGainOrLosseses { get; set; }
        public DbSet<DeferredNonCommercialBusinessLosses> DeferredNonCommercialBusinessLosseses { get; set; }
        public DbSet<Dividends> Dividendses { get; set; }
        public DbSet<ELSP> Elsps { get; set; }
        public DbSet<EmployeeShareSchemes> EmployeeShareSchemeses { get; set; }
        public DbSet<ETP> Etps { get; set; }
        public DbSet<FMISI> Fmisis { get; set; }
        public DbSet<ForeignEntities> ForeignEntitieses { get; set; }
        public DbSet<ForeignSourceIncome> ForeignSourceIncomes { get; set; }
        public DbSet<NetFarmManagementDepositOrRepayments> NetFarmManagementDepositOrRepaymentses { get; set; }
        public DbSet<NetIncomeOrLossFromBusiness> NetIncomeOrLossFromBusinesses { get; set; }
        public DbSet<OtherIncome> OtherIncomes { get; set; }
        public DbSet<PartnershipsAndTrusts> PartnershipsAndTrustses { get; set; }
        public DbSet<PAYGSummary> PaygSummaries { get; set; }
        public DbSet<PersonalServiceIncome> PersonalServiceIncomes { get; set; }
        public DbSet<P1PersonalServicesIncome> P1PersonalServicesIncomes { get; set; }
        public DbSet<P2DescriptionOfMainBusinessOrProfessionalActivity> P2DescriptionOfMainBusinessOrProfessionalActivities { get; set; }
        public DbSet<P4StatusOfBusiness> P4StatusOfBusinesses { get; set; }
        public DbSet<P5BusinessNameOfMainBusinessAndABN> P5BusinessNameOfMainBusinessAndAbns { get; set; }
        public DbSet<P7GSTByInternet> P7GstByInternets { get; set; }
        public DbSet<P8BusinessIncomeAndExpensesNonFarming> P8BusinessIncomeAndExpensesNonFarmings { get; set; }
        public DbSet<P8BusinessIncomeAndExpensesFarming> P8BusinessIncomeAndExpensesFarmings { get; set; }
        public DbSet<P9BusinessLossActivity> P9BusinessLossActivities { get; set; }
        public DbSet<P10SmallBusinessEntityDepreciatingAssets> P10SmallBusinessEntityDepreciatingAssetses { get; set; }
        public DbSet<P11TradeDebtors> P11TradeDebtorses { get; set; }
        public DbSet<P12TradeCreditors> P12TradeCreditorses { get; set; }
        public DbSet<P13TotalSalaryAndWageExpenses> P13TotalSalaryAndWageExpenseses { get; set; }
        public DbSet<P14PaymentsToAssociatedPersons> P14PaymentsToAssociatedPersonses { get; set; }
        public DbSet<P15IntangibleDepreciatingAssetsFirstDeducted> P15IntangibleDepreciatingAssetsFirstDeducteds { get; set; }
        public DbSet<P16OtherDepreciatingAssetsFirstDeducted> P16OtherDepreciatingAssetsFirstDeducteds { get; set; }
        public DbSet<P17TerminationValueOfIntangibleDepreciatingAsset> P17TerminationValueOfIntangibleDepreciatingAssets { get; set; }
        public DbSet<P18TerminationValueOfOtherDepreciatingAssets> P18TerminationValueOfOtherDepreciatingAssetses { get; set; }
        public DbSet<P19TradingStockElection> P19TradingStockElections { get; set; }

        //Deduction Type Details Items
        public DbSet<ComputerLaptopForWork> ComputerLaptopForWorks { get; set; }
        public DbSet<D10CostOfTaxAffairs> D10CostOfTaxAffairses { get; set; }
        public DbSet<D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity> D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuities { get; set; }
        public DbSet<D12PersonalSuperannuationContributions> D12PersonalSuperannuationContributionses { get; set; }
        public DbSet<D13DeductionForProjectPool> D13DeductionForProjectPools { get; set; }
        public DbSet<D14ForestryManagedInvestmentSchemeDeduction> D14ForestryManagedInvestmentSchemeDeductions { get; set; }
        public DbSet<D15OtherDeductions> D15OtherDeductionses { get; set; }
        public DbSet<D1WorkRelatedCarExpenses> D1WorkRelatedCarExpenseses { get; set; }
        public DbSet<D2WorkRelatedTravelExpenses> D2WorkRelatedTravelExpenseses { get; set; }
        public DbSet<D3WorkRelatedUniformClothingLaundryDryCleaning> D3WorkRelatedUniformClothingLaundryDryCleanings { get; set; }
        public DbSet<D4WorkRelatedSelfEducationExpenses> D4WorkRelatedSelfEducationExpenseses { get; set; }
        public DbSet<D9GiftsOrDonations> D9GiftsOrDonationses { get; set; }
        public DbSet<DividendDeduction> DividendDeductions { get; set; }
        public DbSet<HomeOfficeExpense> HomeOfficeExpenses { get; set; }
        public DbSet<HomeOfficeOccupancyCosts> HomeOfficeOccupancyCostses { get; set; }
        public DbSet<InterestDeduction> InterestDeductions { get; set; }
        public DbSet<InternetAccessExpense> InternetAccessExpenses { get; set; }
        public DbSet<LowValuePoolDeduction> LowValuePoolDeductions { get; set; }
        public DbSet<MobilePhoneExpense> MobilePhoneExpenses { get; set; }
        public DbSet<OtherWorkRelatedExpenses> OtherWorkRelatedExpenseses { get; set; }
        public DbSet<ParkAndTolls> ParkAndTollses { get; set; }
        public DbSet<SunProtection> SunProtections { get; set; }
        public DbSet<ToolAndEquipment> ToolAndEquipments { get; set; }
        public DbSet<UnionFees> UnionFeeses { get; set; }

        //Other Type Details Items
        public DbSet<A1Under18> A1Under18s { get; set; }
        public DbSet<A2PartYearTaxFreeThreshold> A2PartYearTaxFreeThresholds { get; set; }
        public DbSet<A3SuperCoContribution> A3SuperCoContributions { get; set; }
        public DbSet<A4WorkingHolidayMakerNetIncome> A4WorkingHolidayMakerNetIncomes { get; set; }
        public DbSet<DependencyChildren> DependencyChildrens { get; set; }
        public DbSet<IncomeTests> IncomeTestses { get; set; }
        public DbSet<L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear> L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYears { get; set; }
        public DbSet<M1MedicareLevyReductionOrExemption> M1MedicareLevyReductionOrExemptions { get; set; }
        public DbSet<M2MedicareLevSurcharge> M2MedicareLevSurcharges { get; set; }
        public DbSet<PrivateHealthInsurancePolicyDetails> PrivateHealthInsurancePolicyDetailses { get; set; }
        public DbSet<SpouseDetails> SpouseDetailses { get; set; }
        public DbSet<T10OtherNonRefundableTaxOffsets> T10OtherNonRefundableTaxOffsetses { get; set; }
        public DbSet<T11OtherRefundableTaxOffsets> T11OtherRefundableTaxOffsetses { get; set; }
        public DbSet<T1SeniorsAndPensioners> T1SeniorsAndPensionerses { get; set; }
        public DbSet<T2AustralianSuperannuationIncomeStream> T2AustralianSuperannuationIncomeStreams { get; set; }
        public DbSet<T3SuperannuationContributionsOnBehalfOfYourSpouse> T3SuperannuationContributionsOnBehalfOfYourSpouses { get; set; }
        public DbSet<T4ZoneOrOverseasForces> T4ZoneOrOverseasForceses { get; set; }
        public DbSet<T6Dependent> T6Dependents { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new DeductionTypeDeductionTypeFormConfiguration());
            builder.ApplyConfiguration(new IncomeTypeIncomeTypeFormConfiguration());
            builder.ApplyConfiguration(new OccupationCategoryDeductionTypeConfiguration());
            builder.ApplyConfiguration(new OccupationCategoryIncomeTypeConfiguration());
            builder.ApplyConfiguration(new OtherItemTypeOtherItemTypeFormConfiguration());

            //builder.Entity<MainForm>().HasOne(a => a.Lodgement).WithOne(b => b.MainForm)
            //    .HasForeignKey<Lodgement>(b => b.MainFormId).OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Lodgement>().HasOne(a => a.MainForm).WithOne(b => b.Lodgement)
            //    .HasForeignKey<MainForm>(b => b.LodgementId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

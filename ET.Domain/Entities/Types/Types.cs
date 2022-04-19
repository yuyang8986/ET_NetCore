
namespace ET.Domain.Entities.Types
{
    public enum AccountTypes
    {
        Individual = 1,
        BusinessMainAccount = 2,
        BusinessSubAccount = 3,
        Member = 4,
        SuperAdmin = 5,
        PremiumAccount = 6
    }


    public static class AllowanceTypes
    {
        // Meals Allowance • Motor Vehicle Allowance • Tools Allowance • Travel Allowance • Travel Allowance - overnight
    //Uniform Allowance • Tips • Directors Fees • Jury Fees • Income Protection Income
        public const string MealAllowance = "Meal Allowance";
        public const string MotorVehicleAllowance = "Motor Vehicle Allowance";
        public const string ToolsAllowance = "Tools Allowance";
        public const string TravelAllowance = "Travel Allowance";
        public const string TravelAllowanceOvernight = "Travel Allowance - overnight";
        public const string UniformAllowance = "Uniform Allowance";
        public const string Tips = "Tips";
        public const string DirectorsFees = "Directors Fees";
        public const string JuryFees = "Jury Fees";
        public const string IncomeProtectionIncome = "Income Protection Income";
    }

    public static class AGATypes
    {
        //Newstart allowance | Youth allowance | Parenting Payment (Partnered) | Mature age allowance | Partner allowance | Sickness allowance | Special benefit | Widow allowance | Austudy payment
        public const string NewstartAllowance = "Newstart allowance";
        public const string YouthAllowance = "Youth allowance";
        public const string ParentingPaymentPartnered = "Parenting Payment (Partnered)";
        public const string Matureageallowance = "Mature age allowance";
        public const string Partnerallowance = "Partner allowance";
        public const string Sicknessallowance = "Sickness allowance";
        public const string Specialbenefit = "Special benefit";
        public const string Widowallowance = "Widow allowance";
        public const string Austudypayment = "Austudy payment";
    }

    public static class AGPTypes
    {
        public const string ParentingPaymentSingle = "Parenting Payment (Single)";
        public const string Agedpension = "Aged pension";
        public const string Disabilitysupportpensionpensionage  = "Disability support pension (if you are of pension age) ";
        public const string Carerpayments = "Carer payments";
    }





    public static class LodgementStatus
    {
        public const string NotStarted = "Not Started";
        public const string Incomplete = "Incomplete";//not submitted
        public const string Completed = "Completed";
        public const string Pending = "Pending";//submitted and wait on response from ato , for backend only
    }

    public static class UploadFileTypes
    {
        public const string PAYGSummary = "PAYGSummary";
    }

    //this need to match the order in DB
    public enum IncomeTypes
    {
        SalaryWages = 1,
        AllowanceEarnings = 2,
        EmployerLumpSumPayment = 3,
        EmploymentTerminationPayments = 4,
        AustralianGovernmentAllowances = 5,
        AustralianAnnuitiesAndSuperannuationIncomeStreams = 6,
        AustralianSuperannuationLumpSumPayments = 7,
        AttributedPersonalServicesIncome = 8,
        BankInterest = 9,
        Dividends = 10,
        EmployeeShareSchemes = 11,
        PartnershipsAndTrusts = 12,
        PersonalServicesIncome = 13,
        NetIncomeOrLossFromBusiness = 14,
        DeferredNoncommercialBusinessLosses = 15,
        NetFarmManagementDepositsOrrepayments = 16,
        Capitalgainsorlosse = 17,
        ForeignEntities = 18,
        Foreignsourceincome = 19,
        Rent = 20,
        BonusesFromLifeInsuranceCompaniesAndFriendlySocieties = 21,
        ForestryManagedInvestmentSchemeIncome = 22,
        OtherIncome = 23,
        PersonalServicesIncomes = 24,
        DescriptionOfMainBusinessOrProfessionalActivity = 25,
        NumberOfBusinessActivities = 26,
        StatusOfYourBusiness = 27,
        BusinessNameOfMainBusinessAndAustralianBusinessNumber = 28,
        BusinessAddressOfMainBusiness = 29,
        GoodsOrServicesByInternet = 30,
        BusinessIncomeAndExpenses = 31,
        BusinessLossActivityDetails = 32,
        SmallBusinessEntityDepreciatingAssets = 33,
        TradeDebtors = 34,
        TradeCreditors = 35,
        TotalSalaryAndWageExpenses = 36,
        PaymentsToAssociatedPersons = 37,
        IntangibleDepreciatingAssetsFirstDeducted = 38,
        OtherDepreciatingAssetsFirstDeducted = 39,
        TerminationValueOfIntangibleDepreciatingAsset = 40,
        TerminationValueOfOtherDepreciatingAssets = 41,
        TradingStockElection = 42
    }

    //this need to match the order in DB
    public enum DeductionTypes
    {
        WorkrelatedCarExpenses = 1,
        ParkingTolls = 2,
        Otherworkrelatedtravelexpenses = 3,
        WorkrelateduniformOccupationSpecificOrProtectiveClothingLaundryAndDryCleaningExpenses = 4,
        WorkrelatedSelfeducationExpenses = 5,
        ToolsandEquipment = 6,
        MobilePhone = 7,
        InternetAccess = 8,
        ComputerLaptopUsedforWorkPurposes = 9,
        UnionFees = 10,
        HomeOfficeExpenses = 11,
        OtherWorkRelatedExpenses = 12,
        HomeOfficeOccupancyCosts = 13,
        SunProtection = 14,
        LowValuePoolDeduction = 15,
        InterestDeductions = 16,
        DividendDeductions = 17,
        GiftsorDonations = 18,
        CostofManagingTaxAffairs = 19,
        DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity = 20,
        PersonalSuperannuationContributions = 21,
        DeductionForProjectPool = 22,
        ForestryManagedInvestmentSchemeDeduction = 23,
        OtherkDeductions = 24

    }

}


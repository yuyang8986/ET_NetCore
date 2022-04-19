using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.DeductionTypeDetailModels;
using Newtonsoft.Json;

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update
{
    public struct DeductionTypeDetailsFormUpdateDto
    {
        [Required]
        public int DeductionTypeDetailId { get; set; }
        [Required]
        public int DeductionTypeId { get; set; }
        [Required]
        public double TotalAmount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ComputerLaptopForWork> ComputerLaptopForWork { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D10CostOfTaxAffairs D10CostOfTaxAffairs { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity D11DeductibleAmountOfUndeductedPurchasePriceOfForeignPensionOrAnnuity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<D12PersonalSuperannuationContributions> D12PersonalSuperannuationContributions { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D13DeductionForProjectPool D13DeductionForProjectPool { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D14ForestryManagedInvestmentSchemeDeduction D14ForestryManagedInvestmentSchemeDeduction { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<D15OtherDeductions> D15OtherDeductions { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D1WorkRelatedCarExpenses D1WorkRelatedCarExpenses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<D2WorkRelatedTravelExpenses> D2WorkRelatedTravelExpenses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D3WorkRelatedUniformClothingLaundryDryCleaning D3WorkRelatedUniformClothingLaundryDryCleaning { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D4WorkRelatedSelfEducationExpenses D4WorkRelatedSelfEducationExpenses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public D9GiftsOrDonations D9GiftsOrDonations { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DividendDeduction DividendDeduction { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<HomeOfficeExpense> HomeOfficeExpense { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public HomeOfficeOccupancyCosts HomeOfficeOccupancyCosts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public InterestDeduction InterestDeduction { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public InternetAccessExpense InternetAccessExpense { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public LowValuePoolDeduction LowValuePoolDeduction { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MobilePhoneExpense MobilePhoneExpense { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OtherWorkRelatedExpenses> OtherWorkRelatedExpenses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ParkAndTolls ParkAndTolls { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SunProtection SunProtection { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ToolAndEquipment ToolAndEquipment { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public UnionFees UnionFees { get; set; }

    }
}

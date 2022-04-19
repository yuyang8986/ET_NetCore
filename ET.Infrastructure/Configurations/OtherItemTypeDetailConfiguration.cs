using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.FormAggregate.IITR.TypeDetailModels.OtherItemTypeDetailModels;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class OtherItemTypeDetailConfiguration: IEntityTypeConfiguration<OtherItemTypeDetail>
    {
        public void Configure(EntityTypeBuilder<OtherItemTypeDetail> builder)
        {
            builder.HasMany<A1Under18>();
            builder.HasMany<A2PartYearTaxFreeThreshold>();
            builder.HasMany<A3SuperCoContribution>();
            builder.HasMany<A4WorkingHolidayMakerNetIncome>();
            builder.HasMany<DependencyChildren>();
            builder.HasMany<IncomeTests>();
            builder.HasMany<L1TaxLossesOfEarlierIncomeYearsClaimedThisIncomeYear>();
            builder.HasMany<M1MedicareLevyReductionOrExemption>();
            builder.HasMany<M2MedicareLevSurcharge>();
            builder.HasMany<PrivateHealthInsurancePolicyDetails>();
            builder.HasMany<SpouseDetails>();
            builder.HasMany<T10OtherNonRefundableTaxOffsets>();
            builder.HasMany<T11OtherRefundableTaxOffsets>();
            builder.HasMany<T1SeniorsAndPensioners>();
            builder.HasMany<T2AustralianSuperannuationIncomeStream>();
            builder.HasMany<T3SuperannuationContributionsOnBehalfOfYourSpouse>();
            builder.HasMany<T4ZoneOrOverseasForces>();
            builder.HasMany<T6Dependent>();
        }
    }
}

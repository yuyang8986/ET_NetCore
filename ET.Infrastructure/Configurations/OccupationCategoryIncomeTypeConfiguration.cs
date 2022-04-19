using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class OccupationCategoryIncomeTypeConfiguration: IEntityTypeConfiguration<OccupationCategoryIncomeType>
    {
        public void Configure(EntityTypeBuilder<OccupationCategoryIncomeType> builder)
        {

           
            builder.HasKey(ur => new { ur.IncomeTypeId, ur.OccupationCategoryId });
            //builder.HasOne(ur => ur.IncomeType)
            //    .WithMany(r => r.OccupationCategoryToIncomeTypes)
            //    .HasForeignKey(ur => ur.IncomeTypeId)
            //    .IsRequired();

            //builder.HasOne(ur => ur.OccupationCategory)
            //    .WithMany(r => r.OccupationCategoryToIncomeTypes)
            //    .HasForeignKey(ur => ur.OccupationCategoryId)
            //    .IsRequired();
            ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class OccupationCategoryDeductionTypeConfiguration:IEntityTypeConfiguration<OccupationCategoryDeductionType>
    {
        public void Configure(EntityTypeBuilder<OccupationCategoryDeductionType> builder)
        {
            builder.HasKey(ur => new { ur.DeductionTypeId, ur.OccupationCategoryId });
            //builder.HasOne(ur => ur.DeductionType)
            //    .WithMany(r => r.OccupationCategoryToDeductionTypes)
            //    .HasForeignKey(ur => ur.DeductionTypeId)
            //    .IsRequired();

            //builder.HasOne(ur => ur.OccupationCategory)
            //    .WithMany(r => r.OccupationCategoryToDeductionTypes)
            //    .HasForeignKey(ur => ur.OccupationCategoryId)
            //    .IsRequired();
            ;
        }
    }
}

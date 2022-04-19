using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class DeductionTypeDeductionTypeFormConfiguration:IEntityTypeConfiguration<DeductionTypeDeductionTypeForm>
    {
        public void Configure(EntityTypeBuilder<DeductionTypeDeductionTypeForm> builder)
        {
            builder
                .HasKey(bc => new { bc.DeductionTypeFormId, bc.DeductionTypeId });
            //builder
            //    .HasOne(bc => bc.DeductionType)
            //    .WithMany(b => b.DeductionTypeToForms)
            //    .HasForeignKey(bc => bc.DeductionTypeFormId);
            //builder
            //    .HasOne(bc => bc.DeductionTypeForm)
            //    .WithMany(c => c.DeductionTypeToForms)
            //    .HasForeignKey(bc => bc.DeductionTypeId);
        }
    }
}

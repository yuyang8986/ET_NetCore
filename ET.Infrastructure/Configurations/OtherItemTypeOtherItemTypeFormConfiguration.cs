using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class OtherItemTypeOtherItemTypeFormConfiguration:IEntityTypeConfiguration<OtherItemTypeOtherItemForm>
    {
        public void Configure(EntityTypeBuilder<OtherItemTypeOtherItemForm> builder)
        {
            builder
                .HasKey(bc => new { bc.OtherItemTypeFormId, bc.OtherItemTypeId });
            //builder
            //    .HasOne(bc => bc.OtherItemType)
            //    .WithMany(b => b.OtherItemTypeToForms)
            //    .HasForeignKey(bc => bc.OtherItemTypeFormId);
            //builder
            //    .HasOne(bc => bc.OtherItemTypeForm)
            //    .WithMany(c => c.OtherItemTypeToForms)
            //    .HasForeignKey(bc => bc.OtherItemTypeId);
        }
    }
}

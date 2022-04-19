using System;
using System.Collections.Generic;
using System.Text;
using ET.Domain.Entities.Aggregate.TaxationAggregate.IITR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ET.Infrastructure.Configurations
{
    class IncomeTypeIncomeTypeFormConfiguration:IEntityTypeConfiguration<IncomeTypeIncomeTypeForm>
    {
        public void Configure(EntityTypeBuilder<IncomeTypeIncomeTypeForm> builder)
        {
            builder.HasKey(bc => new { bc.IncomeTypeFormId, bc.IncomeTypeId });
            //builder.HasOne(bc => bc.IncomeType)
            //    .WithMany(b => b.IncomeTypeToForms)
            //    .HasForeignKey(bc => bc.IncomeTypeFormId);
            //builder.HasOne(bc => bc.IncomeTypeForm)
            //    .WithMany(c => c.IncomeTypeToForms)
            //    .HasForeignKey(bc => bc.IncomeTypeId);
        }
    }
}

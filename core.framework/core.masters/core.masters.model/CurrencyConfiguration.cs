using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.masters.model
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Ccy)
                .IsRequired()
                .HasMaxLength(3);
            builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(255);
            builder.Property(c => c.Symbol)
                .HasMaxLength(3);
            builder.Property(c => c.InUse);
            builder.Property(c => c.LastModified);
        }
    }
}

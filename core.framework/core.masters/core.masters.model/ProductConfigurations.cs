using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.masters.model
{
   class ProductConfigurations : IEntityTypeConfiguration<Product>
   {
      public void Configure(EntityTypeBuilder<Product> builder)
      {
         builder.HasKey(p => p.Id);
         builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(255);
         builder.Property(p => p.Price)
            .IsRequired();
         builder.Property(p => p.InUse);
         builder.Property(p => p.LastModified);
      }
   }
}

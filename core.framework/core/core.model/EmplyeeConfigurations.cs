using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.model
{
   public class EmplyeeConfigurations : IEntityTypeConfiguration<Employee>
   {
      public void Configure(EntityTypeBuilder<Employee> builder)
      {
         builder.HasKey(e => e.Id);
         builder.Property(e => e.FullName).HasMaxLength(255);
         builder.Property(e => e.Designation).HasMaxLength(50);
         builder.Property(e => e.InUse);
         builder.Property(e => e.LastModified);
      }
   }
}

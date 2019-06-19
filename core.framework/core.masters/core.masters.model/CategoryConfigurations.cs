using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.masters.model
{
   public class CategoryConfigurations : IEntityTypeConfiguration<Category>
   {
      public void Configure(EntityTypeBuilder<Category> builder)
      {
         builder.HasKey(c => c.Id);
         builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);
         builder.Property(c => c.InUse);
         builder.Property(c => c.LastModified);
      }
   }
}

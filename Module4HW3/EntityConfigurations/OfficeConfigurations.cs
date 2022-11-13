using Module4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.EntityConfigurations
{
    public class OfficeConfigurations : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.Title).HasColumnName("Title").HasMaxLength(100).IsRequired();
            builder.Property(o => o.Location).HasColumnName("Location").HasMaxLength(100).IsRequired();
        }
    }
}

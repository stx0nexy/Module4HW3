using Module4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.EntityConfigurations
{
    public class TitleConfigurations : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.TitleId).HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
        }
    }
}

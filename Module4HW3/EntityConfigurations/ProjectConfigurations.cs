using Module4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.EntityConfigurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(o => o.ProjectId);
            builder.Property(o => o.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(o => o.Budget).HasColumnName("Budget").HasColumnType("money").IsRequired();
            builder.Property(o => o.StartedTime).HasColumnName("StartedTime").HasColumnType("datetime2")
                .HasMaxLength(7).IsRequired();
        }
    }
}

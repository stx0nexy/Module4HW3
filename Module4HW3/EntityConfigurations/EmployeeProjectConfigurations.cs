using Module4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.EntityConfigurations
{
    public class EmployeeProjectConfigurations : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(o => o.Rate).HasColumnName("Rate").HasColumnType("money").IsRequired();
            builder.Property(o => o.StartedDate).HasColumnName("StartedDate").HasColumnType("datetime2")
                .HasMaxLength(7).IsRequired();
            builder.HasOne(t => t.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(t => t.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(t => t.Project)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

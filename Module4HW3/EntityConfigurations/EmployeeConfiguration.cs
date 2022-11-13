using Module4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HiredDate")
                .HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.HasOne(t => t.Title)
                .WithMany(e => e.Employees)
                .HasForeignKey(t => t.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(o => o.Office)
                .WithMany(e => e.Employees)
                .HasForeignKey(o => o.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

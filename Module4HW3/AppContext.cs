using Module4HW3.Entities;
using Module4HW3.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Module4HW3
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjecst { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfigurations());
            modelBuilder.ApplyConfiguration(new OfficeConfigurations());
            modelBuilder.ApplyConfiguration(new ProjectConfigurations());
            modelBuilder.ApplyConfiguration(new TitleConfigurations());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using EmployeesInformation.Models;

namespace EmployeesInformation.Infrastructure
{
    public partial class EmployeesInfoDbContext : DbContext
    {
        public EmployeesInfoDbContext(DbContextOptions<EmployeesInfoDbContext> options) : base(options)
        {}

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Redeployment> Redeployments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: "dbo");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Position>().ToTable("Position");
            modelBuilder.Entity<Redeployment>().ToTable("Redeployment");
            base.OnModelCreating(modelBuilder);
        }
    }
}
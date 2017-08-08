using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace netcoreApp.Models
{
    public partial class EmployeeContext : DbContext
    {
        public virtual DbSet<EmpMaster> EmpMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseNpgsql(@"Host=employee.cpcqv5lues3g.us-west-2.rds.amazonaws.com;Port=5432;Database=Employee;User ID=softtrends;Password=1Softtrends2;sslmode=Require;Trust Server Certificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpMaster>(entity =>
            {
                entity.HasKey(e => e.EmpName)
                    .HasName("PK_EmpMaster");
            });
        }
    }
}
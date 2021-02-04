using Microsoft.EntityFrameworkCore;
using Repository.Sqlite.Entities;
using System;

namespace Repository.Sqlite
{
    public class SalaryCalculationContext : DbContext
    {
        public SalaryCalculationContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=salary.db");
        }
    }
}

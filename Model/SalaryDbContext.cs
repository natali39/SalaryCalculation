using Microsoft.EntityFrameworkCore;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    class SalaryDbContext : DbContext
    {
        public DbSet<IStaff> Staffs { get; set; }

        public SalaryDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=salary.db");
        }
    }
}

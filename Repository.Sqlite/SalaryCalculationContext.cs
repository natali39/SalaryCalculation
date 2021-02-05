using Microsoft.EntityFrameworkCore;
using Repository.Sqlite.Entities;

namespace Repository.Sqlite
{
    public class SalaryCalculationContext : DbContext
    {
        public SalaryCalculationContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<StaffDb> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=salary.db");
        }
    }
}

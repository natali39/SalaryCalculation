using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public class Report
    {
        public Staff Staff { get; private set; }
        public int Id { get; private set; }
        public string LastName { get; private set; }
        public string Name { get; private set; }
        public decimal BaseSalary { get; private set; }
        public decimal Bonus { get; private set; }
        public decimal TotalSalary { get; private set; }

        public Report(Staff staff, DateTime payDate)
        {
            Id = staff.Id;
            LastName = staff.LastName;
            Name = $"{staff.FirstName} {staff.MiddleName}";
            BaseSalary = staff.BaseSalary;
            TotalSalary = staff.GetSalary(payDate);
        }

        public string PrintStaffReport()
        {
            return $"{Id} {LastName} {Name} {BaseSalary} {TotalSalary}";
        }
    }
}

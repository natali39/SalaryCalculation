using System;
using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime WorkingSince { get; set; }
        public decimal BaseSalary { get; set; }
        public Staff Chief { get; set; }
        

        public virtual decimal CalculateSalary(decimal SalaryRate)
        {
            throw new System.NotImplementedException();
        }

        public decimal GetSalaryAllStaffMembers(List<Staff> staffMembers)
        {
            throw new System.NotImplementedException();
        }
    }
}

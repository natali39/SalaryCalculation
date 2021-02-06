using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public class StaffReport
    {
        public int Id { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string Group { get; set; }
        public DateTime PayDate { get; set; }
        public decimal TotalSalary { get; private set; }
    }
}

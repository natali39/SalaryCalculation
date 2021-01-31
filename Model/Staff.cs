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
        /// <summary>
        /// 
        /// </summary>
        public DateTime WorkingSince { get; set; }
        public decimal BaseSalary { get; set; }
        //public Staff Chief { get; set; }

        public virtual decimal GetSalary(DateTime payDate)
        {
            throw new System.NotImplementedException();
        }

        public decimal GetSalaryAllStaff(List<Staff> staffMembers) //убрать этот метод отсюда
        {
            throw new System.NotImplementedException();
        }
    }
}

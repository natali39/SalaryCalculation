using System;
using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public interface IStaff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Дата приема сотрудника на работу 
        /// </summary>
        public DateTime WorkingSince { get; set; }

        /// <summary>
        /// Размер базовой ставки заработной платы сотрудника
        /// </summary>
        public decimal BaseSalary { get; set; }

        //public Staff Chief { get; set; }

        public decimal GetSalary(DateTime payDate);
    }  
}

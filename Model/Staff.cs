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
        /// Дата приема сотрудника на работу 
        /// </summary>
        public DateTime WorkingSince { get; set; }

        /// <summary>
        /// Размер базовой ставки заработной платы сотрудника
        /// </summary>
        public decimal BaseSalary { get; set; }

        /// <summary>
        /// Начальник
        /// </summary>
        public Staff Chief { get; set; }

        public virtual decimal GetSalary(DateTime payDate)
        {
            return BaseSalary;
        }
    }  
}

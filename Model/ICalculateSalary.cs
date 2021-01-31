using System;

namespace SalaryCalculation.Model
{
    interface ICalculateSalary
    {
        public decimal GetSalary(DateTime payDate);
    }
}

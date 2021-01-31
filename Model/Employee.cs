using System;

namespace SalaryCalculation.Model
{
    public class Employee : Staff, ICalculateSalary
    {
        private const decimal employeeAnnualRate = 0.03M;
        private const decimal maxEmployeeAnnualRate = 0.3M;
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = employeeAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxEmployeeAnnualRate)
                totalRate = maxEmployeeAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            return Math.Round( (BaseSalary + experienceBonus), 2);
        }
    }
}

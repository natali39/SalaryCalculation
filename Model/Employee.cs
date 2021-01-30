using System;

namespace SalaryCalculation.Model
{
    public class Employee : Staff
    {
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = Const.EmployeeAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > Const.MaxEmployeeAnnualRate)
                totalRate = Const.MaxEmployeeAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            return Math.Round( (BaseSalary + experienceBonus), 2);
        }
    }
}

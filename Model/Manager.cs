using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Manager : HighLevelStaff, ICalculateSalary
    {
        private const decimal managerAnnualRate = 0.05M;
        private const decimal maxManagerAnnualRate = 0.4M;
        private const decimal managerRateForSubordinates = 0.005M;
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = managerAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxManagerAnnualRate)
                totalRate = maxManagerAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            var subordinatesBonus = managerRateForSubordinates
                * Subordinates
                .Where(staff => staff is Employee)
                .Sum(staff => staff.GetSalary(payDate));
            return Math.Round( (BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

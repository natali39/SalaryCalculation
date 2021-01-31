using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Salesman : HighLevelStaff, ICalculateSalary
    {
        private const decimal salesmanAnnualRate = 0.01M;
        private const decimal maxSalesmanAnnualRate = 0.35M;
        private const decimal salesmanRateForSubordinates = 0.003M;
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = salesmanAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxSalesmanAnnualRate)
                totalRate = maxSalesmanAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            var SubordinatesSalarySum = Subordinates.Sum(staff => staff.GetSalary(payDate));
            var subordinatesBonus = salesmanRateForSubordinates * SubordinatesSalarySum;
            return Math.Round( (BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

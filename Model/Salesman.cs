using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Salesman : HighLevelStaff, IGetSalary
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal salesmanAnnualRate = 0.01M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxSalesmanAnnualRate = 0.35M;

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных
        /// </summary>
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

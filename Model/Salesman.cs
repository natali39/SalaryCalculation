using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Salesman : HighLevelStaff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal experienceAnnualRate = 0.01M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxExperienceRate = 0.35M;

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных
        /// </summary>
        private const decimal rateForSubordinates = 0.003M;

        public override decimal GetSalary(DateTime payDate)
        {
            var totalExperienceRate = experienceAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalExperienceRate > maxExperienceRate)
                totalExperienceRate = maxExperienceRate;
            var experienceBonus = BaseSalary * totalExperienceRate;
            var SubordinatesSalarySum = Subordinates.Sum(staff => staff.GetSalary(payDate));
            var subordinatesBonus = rateForSubordinates * SubordinatesSalarySum;
            return Math.Round((BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

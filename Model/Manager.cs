using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Manager : HighLevelStaff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal experienceAnnualRate = 0.05M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxExperienceRate = 0.4M;

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных первого уровня
        /// </summary>
        private const decimal rateForSubordinates = 0.005M;

        public override decimal GetSalary(DateTime payDate)
        {
            var totalExperienceRate = experienceAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalExperienceRate > maxExperienceRate)
                totalExperienceRate = maxExperienceRate;
            var experienceBonus = BaseSalary * totalExperienceRate;
            var subordinatesBonus = rateForSubordinates
                * Subordinates
                .Where(staff => staff is Employee)
                .Sum(staff => staff.GetSalary(payDate));
            return Math.Round((BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

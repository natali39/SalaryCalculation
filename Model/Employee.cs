using System;

namespace SalaryCalculation.Model
{
    public class Employee : Staff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal experienceAnnualRate = 0.03M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxExperienceRate = 0.3M;

        public override decimal GetSalary(DateTime payDate)
        {
            var totalExperienceRate = experienceAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalExperienceRate > maxExperienceRate)
                totalExperienceRate = maxExperienceRate;
            var experienceBonus = BaseSalary * totalExperienceRate;
            return Math.Round((BaseSalary + experienceBonus), 2);
        }
    }
}

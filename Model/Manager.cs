using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Manager : HighLevelStaff, IGetSalary
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal managerAnnualRate = 0;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxManagerAnnualRate = 0.4M;

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных первого уровня
        /// </summary>
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
            return Math.Round((BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

using System;

namespace SalaryCalculation.Model
{
    public class Employee : IStaff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal annualRate = 0.03M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxAnnualRate = 0.3M;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime WorkingSince { get; set; }
        public decimal BaseSalary { get; set; }
        public IStaff Chief { get; set; }

        public decimal GetSalary(DateTime payDate)
        {
            var totalRate = annualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxAnnualRate)
                totalRate = maxAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            return Math.Round((BaseSalary + experienceBonus), 2);
        }
    }
}

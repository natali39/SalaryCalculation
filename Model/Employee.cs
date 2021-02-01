using System;

namespace SalaryCalculation.Model
{
    public class Employee : IStaff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal employeeAnnualRate = 0.03M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxEmployeeAnnualRate = 0.3M;

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime WorkingSince { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BaseSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal GetSalary(DateTime payDate)
        {
            var totalRate = employeeAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxEmployeeAnnualRate)
                totalRate = maxEmployeeAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            return Math.Round((BaseSalary + experienceBonus), 2);
        }
    }
}

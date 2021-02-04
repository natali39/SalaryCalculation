﻿using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Salesman : HighLevelStaff
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        private const decimal annualRate = 0.01M;

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        private const decimal maxAnnualRate = 0.35M;

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных
        /// </summary>
        private const decimal rateForSubordinates = 0.003M;

        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = annualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > maxAnnualRate)
                totalRate = maxAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            var SubordinatesSalarySum = Subordinates.Sum(staff => staff.GetSalary(payDate));
            var subordinatesBonus = rateForSubordinates * SubordinatesSalarySum;
            return Math.Round((BaseSalary + experienceBonus + subordinatesBonus), 2);
        }
    }
}

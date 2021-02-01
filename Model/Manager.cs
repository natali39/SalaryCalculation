using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Manager : IGroup//: HighLevelStaff, IGetSalary
    {
        public decimal AnnualRate { get => 0.05M; }
        public decimal MaxAnnualRate { get => 0.4M; }
        public decimal RateForSubordinates { get => 0.005M; }

        public decimal GetSubordinatesSalary(List<Staff> subordinates, DateTime payDate)
        {
            return subordinates
                .Where(staff => staff is Employee)
                .Sum(staff => new SalaryCalculator(staff, payDate).Calculate());
        }


        ///// <summary>
        ///// доля от базовой ставки за каждый год работы
        ///// </summary>
        //private const decimal managerAnnualRate = 0.05M;

        ///// <summary>
        ///// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        ///// </summary>
        //private const decimal maxManagerAnnualRate = 0.4M;

        ///// <summary>
        ///// доля от суммарной зарплаты всех подчененных первого уровня
        ///// </summary>
        //private const decimal managerRateForSubordinates = 0.005M;

        //public override decimal GetSalary(DateTime payDate)
        //{
        //    var totalExperienceRate = managerAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
        //    if (totalExperienceRate > maxManagerAnnualRate)
        //        totalExperienceRate = maxManagerAnnualRate;
        //    var experienceBonus = BaseSalary * totalExperienceRate;
        //    var subordinatesBonus = managerRateForSubordinates
        //        * Subordinates
        //        .Where(staff => staff is Employee)
        //        .Sum(staff => staff.GetSalary(payDate));
        //    return Math.Round((BaseSalary + experienceBonus + subordinatesBonus), 2);
        //}
    }
}

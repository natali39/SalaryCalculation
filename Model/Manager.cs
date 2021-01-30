using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Manager : HighLevelStaff
    {
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = Const.ManagerAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > Const.MaxManagerAnnualRate)
                totalRate = Const.MaxManagerAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            var subordinatesBonus = Const.ManagerRateForSubordinates
                * Subordinates
                .Where(staff => staff is Employee)
                .Sum(staff => staff.GetSalary(payDate));
            return BaseSalary + experienceBonus + subordinatesBonus;
        }
    }
}

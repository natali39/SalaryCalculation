using System;
using System.Linq;

namespace SalaryCalculation.Model
{
    public class Salesman : HighLevelStaff
    {
        public override decimal GetSalary(DateTime payDate)
        {
            var totalRate = Const.SalesmanAnnualRate * TimeCounter.GetTimeInYears(this.WorkingSince, payDate);
            if (totalRate > Const.MaxSalesmanAnnualRate)
                totalRate = Const.MaxSalesmanAnnualRate;
            var experienceBonus = BaseSalary * totalRate;
            var subordinatesBonus = Const.SalesmanRateForSubordinates
                * Subordinates
                .Sum(staff => staff.GetSalary(payDate));
            return BaseSalary + experienceBonus + subordinatesBonus;
        }
    }
}

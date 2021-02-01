using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    //Хотела все рассчеты зарплаты вынести в отдельный класс.
    public class SalaryCalculator
    {
        IGroup group { get; set; }
        Staff staff { get; set; }
        int timeInYears { get; set; }
        DateTime payDate { get; set; }

        public SalaryCalculator(Staff staff, DateTime payDate)
        {
            this.staff = staff;
            this.payDate = payDate;
            group = staff.Group;
            timeInYears = TimeCounter.GetTimeInYears(staff.WorkingSince, payDate);
        }

        public decimal Calculate()
        {
            var totalExperienceRate = group.AnnualRate * timeInYears;
            var experienceBonus = staff.BaseSalary * totalExperienceRate;
            var subordinatesBonus = 0M;

            if (staff is HighLevelStaff)
            {
                var highLevelStaff = staff as HighLevelStaff;

                var totalSubordinatesSalary = group.GetSubordinatesSalary(highLevelStaff.Subordinates, payDate);
                subordinatesBonus = totalSubordinatesSalary * group.RateForSubordinates;
            }

            var totalSalary = staff.BaseSalary + experienceBonus + subordinatesBonus; 

            return totalSalary;
        }
    }
}

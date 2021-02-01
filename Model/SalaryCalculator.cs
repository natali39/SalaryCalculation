using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    //Хотела все рассчеты зарплаты вынести в отдельный класс.
    public class SalaryCalculator
    {
        IStaff staff { get; set; }
        int timeInYears { get; set; }
        DateTime payDate { get; set; }

        public SalaryCalculator(IStaff staff, DateTime payDate)
        {
            this.staff = staff;
            this.payDate = payDate;
        }

        public decimal CalculateSalary()
        {
            throw new System.NotImplementedException();

        }
    }
}

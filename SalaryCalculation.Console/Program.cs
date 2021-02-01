using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var staff = new Staff
            {
                Id = 1,
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                LastName = "Ivanov",
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000,
                Group = new Manager()
            };

            var salaryCalculator = new SalaryCalculator(staff, DateTime.Now);

            var result = salaryCalculator.Calculate();
            Console.WriteLine(result);

            //foreach (var staff in TestData.GetStaffs())
            //{
            //    Console.WriteLine(staff.GetSalary(DateTime.Now));
            //}
        }
    }
}

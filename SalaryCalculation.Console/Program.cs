using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var staff in TestData.GetStaffs())
            {
                Console.WriteLine(staff.GetSalary(DateTime.Now));
            }
        }
    }
}

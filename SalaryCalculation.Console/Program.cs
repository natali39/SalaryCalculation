using SalaryCalculation.Model;
using System;

namespace SalaryCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new StaffService(new StaffDbRepository());

            foreach (var staff in TestData.GetStaffs())
            {
                service.Add(staff);
                //Console.WriteLine(staff.GetSalary(DateTime.Now));
            }

            var staffs = service.GetAll();
            foreach (var staff in staffs)
            {
                Console.WriteLine($"{staff.Id} {staff.LastName} {staff.FirstName} {staff.MiddleName} {staff.WorkingSince} {staff.BaseSalary}");
            }
        }
    }
}

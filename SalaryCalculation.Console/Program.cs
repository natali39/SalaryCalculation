using Repository.Sqlite;
using SalaryCalculation.Model;
using System;
using System.Linq;

namespace SalaryCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new StaffService(new StaffRepository(new SalaryCalculationContext()));

            //var staffs = TestData.GetStaffs();

            //foreach (var staff in staffs)
            //{
            //    service.Add(staff);
            //}

            var staffs = service.GetAll();

            foreach (var staff in staffs)
            {
                Console.WriteLine($"Сотрудник с таб.№{staff.Id} {staff.LastName} относится к группе {staff.Group} и имеет з/п {staff.GetSalary(DateTime.Now)}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}

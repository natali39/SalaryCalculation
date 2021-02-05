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
            //var staff = service.Get(1);
            //Console.WriteLine(staff.GetSalary(DateTime.Now));

            var staffs = service.GetAll();

            //var staffs = TestData.GetStaffs();
            foreach (var staff in staffs)
            {
                //service.Add(staff);
                //Console.WriteLine(staff.GetSalary(DateTime.Now));
                if (staff is HighLevelStaff highLevelStaff)
                {
                    var subordinates = staffs.Where(x => x.ChiefId == highLevelStaff.Id).ToList();

                    highLevelStaff.Subordinates = subordinates;

                    foreach (var sub in highLevelStaff.Subordinates)
                    {
                        Console.WriteLine($"У {staff.LastName} подчиненный {sub.LastName} имеет з/п {sub.GetSalary(DateTime.Now)}");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine($"Сотрудник с таб.№{staff.Id} {staff.LastName} имеет з/п {staff.GetSalary(DateTime.Now)}");
                Console.WriteLine();

                
            }

        }
    }
}

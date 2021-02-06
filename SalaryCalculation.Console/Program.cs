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

            for (int i = 0; i < staffs.Count; i++)
            {
                Console.WriteLine($"{i}:   Сотрудник с таб.№{staffs[i].Id} {staffs[i].LastName} относится к группе {staffs[i].Group} и имеет з/п {staffs[i].GetSalary(DateTime.Now)}");
                Console.WriteLine();
                if (staffs[i] is HighLevelStaff highLevelStaff)
                {
                    Console.WriteLine($"Имееет подчиненных:");
                    foreach (var sub in highLevelStaff.Subordinates)
                    {
                        
                        Console.WriteLine($"Сотрудник с таб.№{sub.Id} {sub.LastName} относится к группе {sub.Group} и имеет з/п {sub.GetSalary(DateTime.Now)}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}

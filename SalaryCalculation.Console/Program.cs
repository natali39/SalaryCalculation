using Repository.Sqlite;
using SalaryCalculation.Model;
using System;

namespace SalaryCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new StaffService(new StaffRepository(new SalaryCalculationContext()));

            var staffs = service.GetAll();

            Console.WriteLine("Список всех сотрудников:");

            for (int i = 0; i < staffs.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Сотрудник {staffs[i].LastName} ({staffs[i].Id}) относится к группе {staffs[i].Group} и имеет з/п {staffs[i].GetSalary(DateTime.Now)}");
                Console.WriteLine();

                if (staffs[i] is HighLevelStaff highLevelStaff)
                {
                    Console.WriteLine($"Имееет подчиненных:");
                    foreach (var sub in highLevelStaff.Subordinates)
                    {
                        Console.WriteLine($"Сотрудник {sub.LastName} ({sub.Id}) относится к группе {sub.Group} и имеет з/п {sub.GetSalary(DateTime.Now)}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

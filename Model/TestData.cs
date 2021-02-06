using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public static class TestData
    {
        public static List<Staff> GetStaffs()
        {
            var staffs = new List<Staff>();

            var staff1 = new Employee()
            {
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                LastName = "Ivanov",
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000,
                Group = Group.Employee
            };
            staffs.Add(staff1);

            var staff2 = new Employee()
            {
                FirstName = "Petr",
                MiddleName = "Petrovich",
                LastName = "Petrov",
                WorkingSince = new DateTime(2009, 12, 1),
                BaseSalary = 30000,
                Group = Group.Employee
            };
            staffs.Add(staff2);

            var staff3 = new Salesman()
            {
                FirstName = "Egor",
                MiddleName = "Ivanovich",
                LastName = "Sedov",
                WorkingSince = new DateTime(2018, 4, 24),
                BaseSalary = 50000,
                Subordinates = new List<Staff> { staff1, staff2 },
                Group = Group.Salesman
            };
            staffs.Add(staff3);

            var staff4 = new Manager()
            {
                FirstName = "Vitaly",
                MiddleName = "Petrovich",
                LastName = "Krasnov",
                WorkingSince = new DateTime(2015, 2, 13),
                BaseSalary = 60000,
                Subordinates = new List<Staff> { staff3 },
                Group = Group.Manager
            };
            staffs.Add(staff4);

            var staff5 = new Manager()
            {
                FirstName = "Ivan",
                MiddleName = "Petrovich",
                LastName = "Belov",
                WorkingSince = new DateTime(2008, 1, 13),
                BaseSalary = 60000,
                Subordinates = new List<Staff> { staff4 },
                Group = Group.Manager
            };
            staffs.Add(staff5);

            var staff6 = new Salesman()
            {
                FirstName = "Denis",
                MiddleName = "Ivanovich",
                LastName = "Chernov",
                WorkingSince = new DateTime(2007, 1, 30),
                BaseSalary = 50000,
                Group = Group.Salesman
            };
            staffs.Add(staff6);

            return staffs;
        }
    }
}

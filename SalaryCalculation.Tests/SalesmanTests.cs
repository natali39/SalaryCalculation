using NUnit.Framework;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculation.Tests
{
    public class SalesmanTests
    {
        //Проверка расчета зарплаты Salesman, у которого нет подчиненных
        [Test]
        public void GetSalary_ListSubordinatesIsEmpty_RightValue()
        {
            var staff = new Salesman()
            {
                WorkingSince = new DateTime(2000, 10, 24),
                BaseSalary = 40000
            };

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff.GetSalary(testDate);

            Assert.AreEqual(salary, 48000.00);
        }

        //Проверка расчета зарплаты Salesman, у которого в списке подчиненных сотрудники разных уровней
        [Test]
        public void GetSalary_WithDifferentSubordinates_RightValue()
        {
            //Размер зарплаты - 30900
            var staff1 = new Employee()
            {
                Id = 1,
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000,
                ChiefId = 3
            };

            //Размер зарплаты - 48000
            var staff2 = new Salesman()
            {
                Id = 2,
                WorkingSince = new DateTime(2000, 10, 24),
                BaseSalary = 40000,
                ChiefId = 3
            };

            //Размер зарплаты - 75000
            var staff3 = new Manager()
            {
                Id = 2,
                WorkingSince = new DateTime(2015, 2, 13),
                BaseSalary = 60000,
                ChiefId = 3
            };

            var staff4 = new Salesman()
            {
                WorkingSince = new DateTime(2018, 4, 24),
                BaseSalary = 50000,
                Subordinates = new List<Staff> { staff1, staff2, staff3 }
            };

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff4.GetSalary(testDate);

            Assert.AreEqual(salary, 51461.70);
        }
    }
}

using NUnit.Framework;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculation.Tests
{
    public class ManagerTests
    {
        //Проверка расчета зарплаты Manager, у которого в списке подчиненных сотрудники разных уровней
        [Test]
        public void GetSalary_WithListDifferentSubordinates_RightValue()
        {
            //Размер зарплаты - 30900
            var staff1 = new Employee()
            {
                Id = 1,
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000,
                ChiefId = 5
            };

            //Размер зарплаты - 48000
            var staff2 = new Salesman()
            {
                Id = 2,
                WorkingSince = new DateTime(2000, 10, 24),
                BaseSalary = 40000,
                ChiefId = 5
            };

            //Размер зарплаты - 51000
            var staff3 = new Salesman()
            {
                Id = 3,
                WorkingSince = new DateTime(2018, 4, 24),
                BaseSalary = 50000,
                ChiefId = 5
            };

            //Размер зарплаты - 75000
            var staff4 = new Manager()
            {
                Id = 4,
                WorkingSince = new DateTime(2015, 2, 13),
                BaseSalary = 60000,
                ChiefId = 5
            };

            var staff5 = new Manager()
            {
                Id = 5,
                WorkingSince = new DateTime(2008, 1, 13),
                BaseSalary = 60000,
                Subordinates = new List<Staff> { staff1, staff2, staff3, staff4 }
            };

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff5.GetSalary(testDate);

            Assert.AreEqual(salary, 84154.50);
        }
    }
}
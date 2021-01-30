using NUnit.Framework;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculation.Tests
{
    public class ManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateSalaryManagerWithListDifferentSubordinates()
        {
            var staff1 = new Employee()
            {
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000
            };

            var staff2 = new Employee()
            {
                WorkingSince = new DateTime(2009, 12, 1),
                BaseSalary = 30000
            };

            var staff3 = new Salesman()
            {
                WorkingSince = new DateTime(2018, 4, 24),
                BaseSalary = 50000,
                Subordinates = new List<Staff> { staff1, staff2 }
            };


            var staff4 = new Manager()
            {
                WorkingSince = new DateTime(2015, 2, 13),
                BaseSalary = 60000,
                Subordinates = new List<Staff> { staff1, staff2, staff3 }
            };

            var staff5 = new Manager()
            {
                WorkingSince = new DateTime(2008, 1, 13),
                BaseSalary = 60000,
                Subordinates = new List<Staff> { staff1, staff2, staff3, staff4 }
            };

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff5.GetSalary(testDate);

            Assert.AreEqual(salary, 84349.50);
        }
    }
}
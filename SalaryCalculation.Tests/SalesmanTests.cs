using NUnit.Framework;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;

namespace SalaryCalculation.Tests
{
    public class SalesmanTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateSalarySalesmanWithoutListSubordinates()
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

        [Test]
        public void CalculateSalarySalesmanWithListDifferentSubordinates()
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

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff3.GetSalary(testDate);

            Assert.AreEqual(salary, 51209.70);
        }
    }
}

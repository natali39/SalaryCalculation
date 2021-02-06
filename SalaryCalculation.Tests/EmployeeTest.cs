using NUnit.Framework;
using SalaryCalculation.Model;
using System;

namespace SalaryCalculation.Tests
{
    public class EmployeeTest
    {
        //Проверка расчета зарплаты Employee, если рассчетная суммарная надбавка
        //за стаж работы меньше максимального процента суммарной надбавки.
        [Test]
        public void GetSalary_ExperienceRatLessThenMax_RightValue()
        {

            var staff = new Employee()
            {
                WorkingSince = new DateTime(2019, 6, 12),
                BaseSalary = 30000
            }; 

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff.GetSalary(testDate);
            
            Assert.AreEqual(salary, 30900.00);
        }

        //Проверка расчета зарплаты Employee, если рассчетная суммарная надбавка
        //за стаж работы превышает максимальный процент суммарной надбавки.
        [Test]
        public void GetSalary_LimitMaxExperienceRate_RightValue()
        {
            var staff = new Employee()
            {
                WorkingSince = new DateTime(2009, 12, 1),
                BaseSalary = 30000
            };

            var testDate = new DateTime(2021, 1, 30);
            var salary = staff.GetSalary(testDate);

            Assert.AreEqual(salary, 39000.00);
        }
    }
}

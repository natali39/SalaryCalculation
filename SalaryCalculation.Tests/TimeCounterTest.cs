using NUnit.Framework;
using SalaryCalculation.Model;
using System;

namespace SalaryCalculation.Tests
{
    public class TimeCounterTest
    {
        [Test]
        public void GetTimeInYears_RightValue()
        {
            var staffWorkingSince = new DateTime(2016, 10, 10);
            var payDate = new DateTime(2021, 02, 28);

            var yearsCount = TimeCounter.GetTimeInYears(staffWorkingSince, payDate);

            Assert.AreEqual(yearsCount, 4);
        }
    }
}

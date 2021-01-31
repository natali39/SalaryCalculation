using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public static class TimeCounter
    {
        private const int countDaysInYear = 365;

        public static int GetTimeInYears(DateTime workingSince, DateTime payDate)
        {
            return (payDate - workingSince).Days / countDaysInYear;
        }
    }
}

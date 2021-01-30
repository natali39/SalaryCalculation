using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public static class TimeCounter
    {
        public static int GetTimeInYears(DateTime workingSince, DateTime payDate)
        {
            return (payDate - workingSince).Days / Const.CountDaysInYear;
        }
    }
}

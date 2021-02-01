using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public class HighLevelStaff
    {
        public List<IStaff> Subordinates { get; set; }

        public HighLevelStaff()
        {
            Subordinates = new List<IStaff>();
        }
    }
}

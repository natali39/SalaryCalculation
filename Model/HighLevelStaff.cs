using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public class HighLevelStaff : Staff
    {
        public List<Staff> Subordinates { get; set; }
    }
}

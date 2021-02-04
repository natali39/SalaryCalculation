using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public class HighLevelStaff : Staff
    {
        public List<Staff> Subordinates { get; set; }

        public HighLevelStaff()
        {
            Subordinates = new List<Staff>();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Repository.Sqlite.Entities
{
    public class StaffDb
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime WorkingSince { get; set; }
        public decimal BaseSalary { get; set; }
        public bool HasChief { get; set; }
        public int ChiefId { get; set; }
        public GroupDb GroupDb { get; set; }
    }
}

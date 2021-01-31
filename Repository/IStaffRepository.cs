using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Repository
{
    interface IStaffRepository
    {
        List<Staff> GetAll();
        void Create(Staff staff);
        Staff Read();
        Staff Update(Staff staff);
        void Delete(Staff staff);
    }
}

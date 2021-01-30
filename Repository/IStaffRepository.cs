using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Repository
{
    interface IStaffRepository
    {
        List<Staff> GetAllStaffs();
        void CreateStaff(Staff staff);
        Staff ReadStaff();
        Staff UpdateStaff(Staff staff);
        void DeleteStaff(Staff staff);
    }
}

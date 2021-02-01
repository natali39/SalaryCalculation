using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Repository
{
    interface IStaffRepository
    {
        List<IStaff> GetAll();
        void Create(IStaff staff);
        IStaff Read();
        IStaff Update(IStaff staff);
        void Delete(IStaff staff);
    }
}

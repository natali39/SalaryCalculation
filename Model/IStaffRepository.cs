using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public interface IStaffRepository
    {
        List<IStaff> GetAll();
        void Add(IStaff staff);
        IStaff Read(int id);
        void Update(IStaff staff);
        void Delete(IStaff staff);
    }
}

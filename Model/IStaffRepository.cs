using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();
        Staff Add(Staff staff);
        Staff Get(int id);
        void Update(Staff staff);
        void Delete(Staff staff);
    }
}

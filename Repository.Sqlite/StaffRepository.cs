using SalaryCalculation.Model;
using System.Collections.Generic;

namespace Repository.Sqlite
{
    public class StaffRepository : IStaffRepository
    {
        private readonly SalaryCalculationContext context;

        public StaffRepository(SalaryCalculationContext context)
        {
            this.context = context;
        }

        public void Add(Staff staff)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Staff staff)
        {
            throw new System.NotImplementedException();
        }

        public List<Staff> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Staff Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Staff staff)
        {
            throw new System.NotImplementedException();
        }
    }
}

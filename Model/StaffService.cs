using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation.Model
{
    public class StaffService
    {
        private IStaffRepository repository { get; set; }

        public StaffService(IStaffRepository repository)
        {
            this.repository = repository;
        }

        public List<IStaff> GetAll()
        {
            return repository.GetAll();
        }

        public void Add(IStaff staff)
        {
            repository.Add(staff);
        }

        public IStaff Read(int id)
        {
            return repository.Read(id);
        }

        public void Update(IStaff staff)
        {
            repository.Update(staff);
        }

        public void Delete(IStaff staff)
        {
            repository.Delete(staff);
        }
    }
}

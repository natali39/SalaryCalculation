using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Staff> GetAll()
        {
            return repository.GetAll();
        }

        public Staff Add(Staff staff)
        {
            return repository.Add(staff);
        }

        public Staff Get(int id)
        {
            return repository.Get(id);
        }

        public void Update(Staff staff)
        {
            repository.Update(staff);
        }

        public void Delete(Staff staff)
        {
            repository.Delete(staff);
        }
    }
}

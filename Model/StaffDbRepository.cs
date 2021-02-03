using Microsoft.EntityFrameworkCore;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculation.Model
{
    public class StaffDbRepository : IStaffRepository
    {
        public void Add(IStaff staff)
        {
            using (var context = new SalaryDbContext())
            {
                context.Staffs.Add(staff);
                context.SaveChanges();
            }
        }

        public void Delete(IStaff staff)
        {
            using (var context = new SalaryDbContext())
            {
                context.Entry(staff).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<IStaff> GetAll()
        {
            using (var context = new SalaryDbContext())
            {
                return context.Staffs.ToList();
            }
        }

        public IStaff Read(int id)
        {
            using (var context = new SalaryDbContext())
            {
                return context.Staffs.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(IStaff staff)
        {
            using (var context = new SalaryDbContext())
            {
                context.Entry(staff).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

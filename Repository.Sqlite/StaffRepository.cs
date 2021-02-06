using Repository.Sqlite.Entities;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Sqlite
{
    public class StaffRepository : IStaffRepository
    {
        private readonly SalaryCalculationContext context;

        public StaffRepository(SalaryCalculationContext context)
        {
            this.context = context;
        }

        public Staff Add(Staff staff)
        {
            var newStaff = ToStaffDb(staff);
            var entity = context.Staffs.Add(newStaff);
            context.SaveChanges();
            return ToStaff(entity.Entity);
        }

        public void Delete(Staff staff)
        {
            throw new System.NotImplementedException();
        }

        public List<Staff> GetAll()
        {
            var staffsDb = context.Staffs.ToList();
            var staffs = new List<Staff>();
            foreach (var staffDb in staffsDb)
            {
                var staff = ToStaff(staffDb);
                GetProperties(staff, staffDb);
                
                staffs.Add(staff);
            }
            return staffs;
        }

        public Staff Get(int id)
        {
            var staffDb = context.Staffs.FirstOrDefault(x => x.Id == id);
            var staff = ToStaff(staffDb);
            GetProperties(staff, staffDb);

            return staff;
        }

        public void Update(Staff staff)
        {
            var staffDb = ToStaffDb(staff);
            context.Entry(staffDb).State = EntityState.Modified;
            context.SaveChanges();
        }

        private Staff ToStaff(StaffDb staffDb)
        {
            switch (staffDb.GroupDb)
            {
                case GroupDb.Employee:
                    return new Employee();

                case GroupDb.Salesman:
                    return new Salesman();

                case GroupDb.Manager:
                    return new Manager();

                default:
                    throw new Exception("Wrong Group " + staffDb.GroupDb);
            }
        }

        private void GetProperties(Staff staff, StaffDb staffDb)
        {
            staff.Id = staffDb.Id;
            staff.FirstName = staffDb.FirstName;
            staff.MiddleName = staffDb.MiddleName;
            staff.LastName = staffDb.LastName;
            staff.WorkingSince = staffDb.WorkingSince;
            staff.BaseSalary = staffDb.BaseSalary;
            staff.ChiefId = staffDb.ChiefId;
            staff.Group = ToGroup(staffDb.GroupDb);
            if (staff is HighLevelStaff highLevelStaff)
            {
                GetStaffSubordinates(highLevelStaff);
            }
        }

        private void GetStaffSubordinates(HighLevelStaff highLevelStaff)
        {
            var staffsDb = context.Staffs
                .Where(x => x.ChiefId == highLevelStaff.Id)
                .ToList();

            if (staffsDb.Count == 0)
                return;

            foreach (var staffDb in staffsDb)
            {
                var subordinate = ToStaff(staffDb);
                GetProperties(subordinate, staffDb);
                highLevelStaff.Subordinates.Add(subordinate);
            }
        }

        private StaffDb ToStaffDb(Staff staff)
        {
            return new StaffDb
            {
                FirstName = staff.FirstName,
                MiddleName = staff.MiddleName,
                LastName = staff.LastName,
                WorkingSince = staff.WorkingSince,
                BaseSalary = staff.BaseSalary,
                ChiefId = staff.ChiefId,
                GroupDb = ToGroupDb(staff.Group)
            };
        }

        private GroupDb ToGroupDb(Group group)
        {
            switch (group)
            {
                case Group.Employee:
                    return GroupDb.Employee;

                case Group.Salesman:
                    return GroupDb.Salesman;

                case Group.Manager:
                    return GroupDb.Manager;

                default:
                    return 0;
            }
        }

        private Group ToGroup(GroupDb groupDb)
        {
            switch (groupDb)
            {
                case GroupDb.Employee:
                    return Group.Employee;

                case GroupDb.Salesman:
                    return Group.Salesman;

                case GroupDb.Manager:
                    return Group.Manager;

                default:
                    return 0;
            }
        }
    }
}

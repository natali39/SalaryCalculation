using Repository.Sqlite.Entities;
using SalaryCalculation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var newStaff = ToStaffDb(staff);
            context.Staffs.Add(newStaff);
            context.SaveChanges();
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
                staffs.Add(staff);
            }
            return staffs;
        }

        public Staff Get(int id)
        {
            var staffDb = context.Staffs.FirstOrDefault(x => x.Id == id);
            var staff = ToStaff(staffDb);
            return staff;
        }

        public void Update(Staff staff)
        {
            throw new System.NotImplementedException();
        }

        private Staff ToStaff(StaffDb staffDb)
        {
            var staff = new Staff();

            switch (staffDb.GroupDb)
            {
                case GroupDb.Employee:
                    staff = new Employee();
                    break;

                case GroupDb.Salesman:
                    staff = new Salesman();
                    break;

                case GroupDb.Manager:
                    staff = new Manager();
                    break;

                default:
                    throw new Exception("Wrong Group " + staffDb.GroupDb);
            }

            staff.Id = staffDb.Id;
            staff.FirstName = staffDb.FirstName;
            staff.MiddleName = staffDb.MiddleName;
            staff.LastName = staffDb.LastName;
            staff.WorkingSince = staffDb.WorkingSince;
            staff.BaseSalary = staffDb.BaseSalary;
            staff.HasChief = staffDb.HasChief;
            staff.ChiefId = staffDb.ChiefId;
            staff.Group = ToGroup(staffDb.GroupDb);
                        
            return staff;
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
                HasChief = staff.HasChief,
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

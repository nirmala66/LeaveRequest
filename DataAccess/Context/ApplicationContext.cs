using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("LeaveRequest") { }
        public DbSet<AvailableLeave> AvailableLeaves { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }

        public object Entry(Department get)
        {
            throw new NotImplementedException();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Regency> Regencies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Village> Villages { get; set; }
    }
}

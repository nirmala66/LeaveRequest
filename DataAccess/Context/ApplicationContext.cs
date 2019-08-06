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
        public DbSet<AvailableLeave> AvailableLeave { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<LeaveHistory> LeaveHistory { get; set; }
        public DbSet<LeaveRequest> LeaveRequest { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Parameter> Parameter { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Regency> Regency { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Village> Village { get; set; }
    }
}

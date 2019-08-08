using Common.Repositories.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class EmployeeStatusRepository : IEmployeeStatusRepository
    {
        bool status = false;
        ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int Id)
        {
            var get = Get(Id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<EmployeeStatus> Get()
        {
            var get = applicationContext.EmployeeStatus.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<EmployeeStatus> Get(string value)
        //{
        //    var get = applicationContext.EmployeeStatus.Where(x => (x.JoinDate.ToString().Contains(value) || x.EndDate.ToString().Contains(value) || x.Status.ToString().Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public EmployeeStatus Get(int id)
        {
            var get = applicationContext.EmployeeStatus.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(EmployeeStatusVM employeestatusVM)
        {
            var push = new EmployeeStatus(employeestatusVM);
            applicationContext.EmployeeStatus.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int Id, EmployeeStatusVM employeestatusVM)
        {
            var get = Get(Id);
            get.Update(employeestatusVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

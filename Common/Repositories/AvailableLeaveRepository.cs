using Common.Repository.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public class AvailableLeaveRepository : IAvailableLeaveRepository
    { 
        //comment again again again
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

        public List<AvailableLeave> Get()
        {
            var get = applicationContext.AvailableLeaves.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<AvailableLeave> Get(string value)
        {
            var get = applicationContext.AvailableLeaves.Where(x => (x.Id.ToString().Contains(value) || x.LastYear.Contains(value) || x.ThisYear.Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public AvailableLeave Get(int id)
        {
            var get = applicationContext.AvailableLeaves.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(AvailableLeaveVM availableleaveVM)
        {
            var push = new AvailableLeave(availableleaveVM);
            applicationContext.AvailableLeaves.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int Id, AvailableLeaveVM availableleaveVM)
        {
            var get = Get(Id);
            get.Update(availableleaveVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

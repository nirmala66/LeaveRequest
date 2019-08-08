using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccess.Context;
using Common.Repositories.Interfaces;

namespace Common.Repositories
{
    public class HolidayRepository : IHolidayRepository
    {
        bool status = false;
        ApplicationContext applicationContext = new ApplicationContext();

        public List<Holiday> Get()
        {
            var get = applicationContext.Holidays.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Holiday> Get(string value)
        //{
<<<<<<< HEAD
        //    var get = applicationContext.Holidaies.Where(x => (x.Id.ToString().Contains(value) || x.HolidayDate.ToString().Contains(value)||x.Day.Contains(value)|| x.HolidayName.Contains(value)) && x.IsDelete == false).ToList();
=======
        //    var get = applicationContext.Holidays.Where(x => (x.Id.ToString().Contains(value) || x.HolidayDate.ToString().Contains(value)||x.Day.Contains(value)|| x.HolidayName.Contains(value)) && x.IsDelete == false).ToList();
>>>>>>> remotes/origin/08Agustus
        //    return get;
        //}

        public Holiday Get(int id)
        {
            var get = applicationContext.Holidays.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(HolidayVM holidayVM)
        {
            var push = new Holiday(holidayVM);
            applicationContext.Holidays.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, HolidayVM holidayVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(holidayVM);
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}

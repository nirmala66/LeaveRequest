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
    public class PositionRepository : IPositionRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public object EntityState { get; private set; }

        //public bool Delete(int id)
        //{
        //    var get = Get(id);
        //    get.Delete();
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}

        public List<Position> Get()
        {
            var get = applicationContext.Positions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Position> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Positions.Where(x => (x.Name.Contains(value) || Convert.ToString(x.Id).Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Position Get(int id)
        {
            var get = applicationContext.Positions.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(PositionVM positionVM)
        {
            var push = new Position(positionVM);
            applicationContext.Positions.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, PositionVM positionVM)
        //{
        //    var get = Get(id);
        //    get.Update(positionVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

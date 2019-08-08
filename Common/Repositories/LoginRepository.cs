using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace Common.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<Login> Get()
        {
            var get = applicationContext.Login.Include("Roles").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Login> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Login.Include("Roles").Where(x => (x.Email.Contains(value) || Convert.ToString(x.Id).Contains(value) || x.Password.ToString().Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Login Get(int id)
        {
            var get = applicationContext.Login.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(LoginVM loginVM)
        {
            var push = new Login(loginVM);
            applicationContext.Login.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, LoginVM loginVM)
        {
            var get = Get(id);
            get.Update(loginVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

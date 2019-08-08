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
    public class CategoryRepository : ICategoryRepository
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

        public List<Category> Get()
        {
            var get = applicationContext.Categories.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Category> Get(string value)
        //{
        //    var get = applicationContext.Categories.Where(x => (x.Name.ToString().Contains(value) || x.TotalDays.ToString().Contains(value) || x.Description.ToString().Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Category Get(int id)
        {
            var get = applicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(CategoryVM categoryVM)
        {
            var push = new Category(categoryVM);
            applicationContext.Categories.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int Id, CategoryVM categoryVM)
        {
            var get = Get(Id);
            get.Update(categoryVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

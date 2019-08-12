﻿using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace Common.Repositories
{
    public class RegencyRepository : IRegencyRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        //public bool Delete(int id)
        //{
        //    var get = Get(id);
        //    get.Delete();
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}

        public List<Regency> Get()
        {
            var get = applicationContext.Regencies.Include("Province").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Regency> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Regencies.Include("Province").Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value) || x.Province.Name.Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Regency Get(int id)
        {
            var get = applicationContext.Regencies.Include("Province").SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(RegencyVM regencyVM)
        {
            var push = new Regency(regencyVM);
            //ini nih foreign key
            var getProvince = applicationContext.Provinces.SingleOrDefault(x => x.IsDelete == false && x.Id == regencyVM.Province_Id);
            push.Province = getProvince;
            applicationContext.Regencies.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, RegencyVM regencyVM)
        //{
        //    var get = Get(id);
        //    var getProvince = applicationContext.Provinces.SingleOrDefault(x => x.IsDeleted == false && x.Id == regencyVM.Province_Id);
        //    get.Province = getProvince;
        //    get.Update(regencyVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

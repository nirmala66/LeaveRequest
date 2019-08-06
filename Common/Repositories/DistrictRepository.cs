﻿using System;
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
    public class DistrictRepository : IDistrictRepository
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

        public List<District> Get()
        {
            var get = applicationContext.Districts.Include("Regencies").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<District> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Districts.Include("Regencies").Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value) || x.Regency.Name.Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public District Get(int id)
        {
            var get = applicationContext.Districts.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(DistrictVM districtVM)
        {
            var push = new District(districtVM);
            //ini nih foreign key
            var getRegency = applicationContext.Regencies.SingleOrDefault(x => x.IsDelete == false && x.Id == districtVM.Regency_Id);
            push.Regency = getRegency;
            applicationContext.Districts.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, DistrictVM districtVM)
        //{
        //    var get = Get(id);
        //    var getRegency = applicationContext.Regencies.SingleOrDefault(x => x.IsDeleted == false && x.Id == districtVM.Regency_Id);
        //    get.Regency = getRegency;
        //    get.Update(districtVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

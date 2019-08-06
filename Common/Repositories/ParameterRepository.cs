﻿using Common.Repository.Interfaces;
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
    public class ParameterRepository : IParameterRepository
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

        public List<Parameter> Get()
        {
            var get = applicationContext.Parameters.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<Parameter> Get(string value)
        {
            var get = applicationContext.Parameters.Where(x => (x.Id.ToString().Contains(value) || x.Name.Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public Parameter Get(int id)
        {
            var get = applicationContext.Parameters.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ParameterVM parameterVM)
        {
            var push = new Parameter(parameterVM);
            applicationContext.Parameters.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int Id, ParameterVM parameterVM)
        {
            var get = Get(Id);
            get.Update(parameterVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

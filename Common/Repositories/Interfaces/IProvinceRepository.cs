﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IProvinceRepository
    {
        List<Province> Get();
        Province Get(int id);
        List<Province> Get(string value);
        bool Insert(ProvinceVM provinceVM);
        //bool Update(int id, ProvinceVM provinceVM);
        //bool Delete(int id);
    }
}

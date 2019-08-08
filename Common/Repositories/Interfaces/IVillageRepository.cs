﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IVillageRepository
    {
        List<Village> Get();
        Village Get(int id);
        bool Insert(VillageVM villageVM);
        //bool Update(int id, VillageVM villageVM);
        //bool Delete(int id);
    }
}

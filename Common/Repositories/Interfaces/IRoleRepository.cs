﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> Get();
        Role Get(int id);
        bool Insert(RoleVM roleVM);
        //bool Update(int id, RoleVM roleVM);
        //bool Delete(int id);
    }
}

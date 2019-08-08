﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IDepartmentService
    {
        List<Department> Get();
        Department Get(int id);
        bool Insert(DepartmentVM departmentVM);
        //bool Update(int id, DepartmentVM departmentVM);
        //bool Delete(int id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();
        Employee Get(int id);
        Employee GetLast();
<<<<<<< HEAD
=======
        //List<Employee> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(EmployeeVM employeeVM);
        //bool Update(int id, EmployeeVM employeeVM);
        //bool Delete(int id);
    }
}

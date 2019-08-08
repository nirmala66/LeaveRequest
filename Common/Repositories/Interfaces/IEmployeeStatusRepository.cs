using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IEmployeeStatusRepository
    {
        List<EmployeeStatus> Get();
        EmployeeStatus Get(int id);
<<<<<<< HEAD
=======
        //List<EmployeeStatus> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(EmployeeStatusVM employeestatusVM);
        bool Update(int id, EmployeeStatusVM employeestatusVM);
        bool Delete(int id);
    }
}

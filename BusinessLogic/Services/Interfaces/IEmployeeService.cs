using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> Get();
        Employee Get(int id);
<<<<<<< HEAD
        //Employee GetLast();
        //List<Employee> Get(string value);
=======
        Employee GetLast();
   //     List<Employee> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(EmployeeVM employeeVM);
        //bool Update(int id, EmployeeVM employeeVM);
        //bool Delete(int id);
    }
}

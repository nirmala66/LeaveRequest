using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> Get();
        Department Get(int id);
<<<<<<< HEAD
        //List<Department> Get(string value);
=======
 //       List<Department> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(DepartmentVM departmentVM);
        //bool Update(int id, DepartmentVM departmentVM);
        //bool Delete(int id);
    }
}

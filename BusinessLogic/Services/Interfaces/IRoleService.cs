using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IRoleService
    {
        List<Role> Get();
        Role Get(int id);
<<<<<<< HEAD
=======
        //List<Role> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(RoleVM roleVM);
        //bool Update(int id, RoleVM roleVM);
        //bool Delete(int id);
    }
}

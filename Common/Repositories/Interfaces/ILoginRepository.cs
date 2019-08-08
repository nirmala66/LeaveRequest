using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        List<Login> Get();
        Login Get(int id);
<<<<<<< HEAD
=======
        //List<Login> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(LoginVM parameterVM);
        //bool Update(int id, LoginVM parameterVM);
        //bool Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IRegencyRepository
    {
        List<Regency> Get();
        Regency Get(int id);
<<<<<<< HEAD
=======
        //List<Regency> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(RegencyVM regencyVM);
        //bool Update(int id, RegencyVM regencyVM);
        //bool Delete(int id);
    }
}

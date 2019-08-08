using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repositories.Interfaces
{
    public interface IProvinceRepository
    {
        List<Province> Get();
        Province Get(int id);
<<<<<<< HEAD
        //List<Province> Get(string value);
=======
   //     List<Province> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(ProvinceVM provinceVM);
        //bool Update(int id, ProvinceVM provinceVM);
        //bool Delete(int id);
    }
}

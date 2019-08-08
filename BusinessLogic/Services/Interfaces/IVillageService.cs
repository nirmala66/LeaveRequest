using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IVillageService
    {
        List<Village> Get();
        Village Get(int id);
<<<<<<< HEAD
      //  List<Village> Get(string value);
=======
       // List<Village> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(VillageVM villageVM);
        //bool Update(int id, VillageVM villageVM);
        //bool Delete(int id);
    }
}

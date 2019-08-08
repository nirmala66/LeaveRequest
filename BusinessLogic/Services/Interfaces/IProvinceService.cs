using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IProvinceService
    {
        List<Province> Get();
        Province Get(int id);
        bool Insert(ProvinceVM provinceVM);
        //bool Update(int id, ProvinceVM provinceVM);
        //bool Delete(int id);
    }
}

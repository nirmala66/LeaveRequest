using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> Get();
        Category Get(int id);
      //  List<Category> Get(string value);
        bool Insert(CategoryVM categoryVM);
        bool Update(int id, CategoryVM categoryVM);
        bool Delete(int id);
    }
}

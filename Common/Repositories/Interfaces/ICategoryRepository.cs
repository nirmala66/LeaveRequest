using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        Category Get(int id);
<<<<<<< HEAD
=======
        //List<Category> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(CategoryVM categoryVM);
        bool Update(int id, CategoryVM categoryVM);
        bool Delete(int id);
    }
}

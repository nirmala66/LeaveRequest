using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface ILoginService
    {
        List<Login> Get();
        Login Get(int id);
        //List<Login> Get(string value);
        bool Insert(LoginVM parameterVM);
        //bool Update(int id, LoginVM parameterVM);
        //bool Delete(int id);
    }
}

using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IParameterService
    {
        List<Parameter> Get();
        Parameter Get(int id);
<<<<<<< HEAD
       // List<Parameter> Get(string value);
=======
   //     List<Parameter> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(ParameterVM parameterVM);
        bool Update(int id, ParameterVM parameterVM);
        bool Delete(int id);
    }
}

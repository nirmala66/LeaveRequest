﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IDivisionService
    {
        List<Division> Get();
        Division Get(int id);
<<<<<<< HEAD
      //  List<Division> Get(string value);
=======
     //   List<Division> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(DivisionVM divisionVM);
        //bool Update(int id, DivisionVM divisionVM);
        //bool Delete(int id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services.Interfaces
{
    public interface IPositionService
    {
        List<Position> Get();
        Position Get(int id);
<<<<<<< HEAD
=======
        //List<Position> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(PositionVM positionVM);
        //bool Update(int id, PositionVM positionVM);
        //bool Delete(int id);
    }
}

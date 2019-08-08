using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IAvailableLeaveService
    {
        List<AvailableLeave> Get();
        AvailableLeave Get(int id);
        //List<AvailableLeave> Get(string value);
        bool Insert(AvailableLeaveVM availableleaveVM);
        bool Update(int id, AvailableLeaveVM availableleaveVM);
        bool Delete(int id);
    }
}

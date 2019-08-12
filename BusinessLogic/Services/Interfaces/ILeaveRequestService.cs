using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface ILeaveRequestService
    {
        List<LeaveRequest> Get();
        
        LeaveRequest Get(int id);
  //      List<LeaveRequest> Get(string value);

        bool Insert(LeaveRequestVM leaveRequestVM);
        bool Update(int id, LeaveRequestVM leaveRequestVM);
        bool Delete(int id);
    }
}

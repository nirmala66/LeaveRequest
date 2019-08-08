﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface ILeaveRequestRepository
    {
        List<LeaveRequest> Get();
        
        LeaveRequest Get(int id);
        //List<LeaveRequest> Get(string value);

        bool Insert(LeaveRequestVM leaveRequestVM);
        bool Update(int id, LeaveRequestVM leaveRequestVM);
        bool Delete(int id);
    }
}

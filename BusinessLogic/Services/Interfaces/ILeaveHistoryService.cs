﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{

    public interface ILeaveHistoryService
    {
        List<LeaveHistory> Get();

        LeaveHistory Get(int id);
        //List<LeaveHistory> Get(string value);

        bool Insert(LeaveHistoryVM leaveHistoryVM);
        bool Update(int id, LeaveHistoryVM leaveHistoryVM);
        bool Delete(int id);
    }
 }


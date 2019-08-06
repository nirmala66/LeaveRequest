using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Interfaces
{
    public interface IEmployeeStatusRepository
    {
        List<EmployeeStatus> Get();
        EmployeeStatus Get(int id);
        List<EmployeeStatus> Get(string value);
        bool Insert(EmployeeStatusVM employeestatusVM);
        bool Update(int id, EmployeeStatusVM employeestatusVM);
        bool Delete(int id);
    }
}

using BusinessLogic.Services.Interfaces;
using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        bool status = false;

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public EmployeeService() { }
        public List<Employee> Get()
        {
            var result = _employeeRepository.Get();
            return result;
        }

        public Employee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _employeeRepository.Get(id);
                return result;
            }
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.FirstName) || string.IsNullOrWhiteSpace(employeeVM.LastName) || string.IsNullOrWhiteSpace(employeeVM.Gender.ToString()) || string.IsNullOrWhiteSpace(employeeVM.Religion) || string.IsNullOrWhiteSpace(employeeVM.Marital_Status) || string.IsNullOrWhiteSpace(employeeVM.Num_Of_Children) || string.IsNullOrWhiteSpace(employeeVM.Manager_Id.ToString()) || string.IsNullOrWhiteSpace(employeeVM.Department_Id.ToString()) || string.IsNullOrWhiteSpace(employeeVM.Position_Id.ToString()) || string.IsNullOrWhiteSpace(employeeVM.Village_Id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _employeeRepository.Insert(employeeVM);
                return result;
            }
        }
    }
}

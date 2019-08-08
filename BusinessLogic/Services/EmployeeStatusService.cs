using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class EmployeeStatusService : IEmployeeStatusService
    {
        bool status = false;
        private readonly IEmployeeStatusRepository _employeestatusRepository;
        public EmployeeStatusService(IEmployeeStatusRepository employeestatusRepository)
        {
            _employeestatusRepository = employeestatusRepository;
        }

        public List<EmployeeStatus> Get()
        {
            var result = _employeestatusRepository.Get();
            return result;
        }

        public EmployeeStatus Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _employeestatusRepository.Get(id);
                return result;
            }
        }

        public bool Insert(EmployeeStatusVM employeestatusVM)
        {
            if(string.IsNullOrWhiteSpace(employeestatusVM.JoinDate.ToString()) || string.IsNullOrWhiteSpace(employeestatusVM.EndDate.ToString()) || string.IsNullOrWhiteSpace(employeestatusVM.Status))
            {
                return status;
            }
            else
            {
                var result = _employeestatusRepository.Insert(employeestatusVM);
                return result;
            }
        }

        public bool Update(int id, EmployeeStatusVM employeestatusVM)
        {
            if (string.IsNullOrWhiteSpace(employeestatusVM.JoinDate.ToString()) || string.IsNullOrWhiteSpace(employeestatusVM.EndDate.ToString()) || string.IsNullOrWhiteSpace(employeestatusVM.Status))
            {
                return status;
            }
            else
            {
                var result = _employeestatusRepository.Update(id, employeestatusVM);
                return result;
            }
        }

        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _employeestatusRepository.Delete(id);
                return result;
            }
        }
    }
}

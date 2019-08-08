using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class ParameterService : IParameterService
    {
        bool status = false;
        private readonly IParameterRepository _parameterRepository;
        public ParameterService(IParameterRepository parameterRepository)
        {
            _parameterRepository = parameterRepository;
        }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _parameterRepository.Delete(id);
                return result;
            }
        }

        public List<Parameter> Get()
        {
            var result = _parameterRepository.Get();
            return result;
        }

        public Parameter Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _parameterRepository.Get(id);
                return result;
            }
        }

        public bool Insert(ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(parameterVM.Name) || string.IsNullOrWhiteSpace(parameterVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                var result = _parameterRepository.Insert(parameterVM);
                return result;
            }
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(parameterVM.Name) || string.IsNullOrWhiteSpace(parameterVM.Value.ToString()))
            {
                return status;
            }
            else
            {
                var result = _parameterRepository.Update(id, parameterVM);
                return result;
            }
        }
    }
}

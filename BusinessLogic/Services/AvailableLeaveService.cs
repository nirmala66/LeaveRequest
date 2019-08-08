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
    public class AvailableLeaveService : IAvailableLeaveService
    {
        bool status = false;
        private readonly IAvailableLeaveRepository _availableleaveRepository;
        public AvailableLeaveService(IAvailableLeaveRepository availableleaveRepository)
        {
            _availableleaveRepository = availableleaveRepository;
        }
        public bool Delete(int id)
        {
            if(string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _availableleaveRepository.Delete(id);
                return result;
            }
        }

        public List<AvailableLeave> Get()
        {
            var result = _availableleaveRepository.Get();
            return result;
        }

        public AvailableLeave Get(int id)
        { 
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _availableleaveRepository.Get(id);
                return result;
            }
        }

        public bool Insert(AvailableLeaveVM availableleaveVM)
        {
            if(string.IsNullOrWhiteSpace(availableleaveVM.LastYear) || string.IsNullOrWhiteSpace(availableleaveVM.ThisYear))
            {
                return status;
            }
            else
            {
                var result = _availableleaveRepository.Insert(availableleaveVM);
                return result;
            }
        }

        public bool Update(int id, AvailableLeaveVM availableleaveVM)
        {
            if(string.IsNullOrWhiteSpace(availableleaveVM.LastYear) || string.IsNullOrWhiteSpace(availableleaveVM.ThisYear))
            {
                return status;
            }
            else
            {
                var result = _availableleaveRepository.Update(id, availableleaveVM);
                return result;
            }
        }
    }
}

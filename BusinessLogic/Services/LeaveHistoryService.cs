using BusinessLogic.Services.Interfaces;
using Common.Repositories.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LeaveHistoryService : ILeaveHistoryService
    {
        bool status = false;
        private readonly ILeaveHistoryRepository _leaveHistoryRepository;
        public LeaveHistoryService(ILeaveHistoryRepository leaveHistoryRepository)
        {
            _leaveHistoryRepository = leaveHistoryRepository;
        }
        public LeaveHistoryService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveHistoryRepository.Delete(id);
                return result;
            }
        }

        public List<LeaveHistory> Get()
        {
            var result = _leaveHistoryRepository.Get();
            return result;
        }
   

        public LeaveHistory Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _leaveHistoryRepository.Get(id);
                return result;
            }

        }



        public bool Insert(LeaveHistoryVM leaveHistoryVM)
        {
            if (string.IsNullOrWhiteSpace(leaveHistoryVM.FromDate.ToString()) || string.IsNullOrWhiteSpace(leaveHistoryVM.ToDate.ToString()) ||
                string.IsNullOrWhiteSpace(leaveHistoryVM.Reason) || string.IsNullOrWhiteSpace(leaveHistoryVM.ApproverComments) || string.IsNullOrWhiteSpace(leaveHistoryVM.Status) ||
                string.IsNullOrWhiteSpace(leaveHistoryVM.Employee.ToString()) || string.IsNullOrWhiteSpace(leaveHistoryVM.Category.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveHistoryRepository.Insert(leaveHistoryVM);
                return result;

            }
        }

        public bool Update(int id, LeaveHistoryVM leaveHistoryVM)
        {
            if (string.IsNullOrWhiteSpace(leaveHistoryVM.FromDate.ToString()) || string.IsNullOrWhiteSpace(leaveHistoryVM.ToDate.ToString()) ||
                string.IsNullOrWhiteSpace(leaveHistoryVM.Reason) || string.IsNullOrWhiteSpace(leaveHistoryVM.ApproverComments) || string.IsNullOrWhiteSpace(leaveHistoryVM.Status) ||
                string.IsNullOrWhiteSpace(leaveHistoryVM.Employee.ToString()) || string.IsNullOrWhiteSpace(leaveHistoryVM.Category.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveHistoryRepository.Update(id, leaveHistoryVM);
                return result;

            }
        }
    }
}

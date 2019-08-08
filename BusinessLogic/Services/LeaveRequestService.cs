using BusinessLogic.Services.Interfaces;
using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LeaveRequestService : ILeaveRequestService
    {
        bool status = false;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
        }
        public LeaveRequestService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveRequestRepository.Delete(id);
                return result;
            }
        }

        public List<LeaveRequest> Get()
        {

            var result = _leaveRequestRepository.Get();
            return result;
        }

        public LeaveRequest Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _leaveRequestRepository.Get(id);
                return result;
            }
    
        }

        public bool Insert(LeaveRequestVM leaveRequestVM)
        {

            if (string.IsNullOrWhiteSpace(leaveRequestVM.FromDate.ToString()) || string.IsNullOrWhiteSpace(leaveRequestVM.ToDate.ToString())||
                string.IsNullOrWhiteSpace(leaveRequestVM.Reason)|| string.IsNullOrWhiteSpace(leaveRequestVM.ApproverComments) || string.IsNullOrWhiteSpace(leaveRequestVM.Status)||
                string.IsNullOrWhiteSpace(leaveRequestVM.Employee.ToString()) || string.IsNullOrWhiteSpace(leaveRequestVM.Category.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveRequestRepository.Insert(leaveRequestVM);
                return result;

            }
        }

        public bool Update(int id, LeaveRequestVM leaveRequestVM)
        {
            if (string.IsNullOrWhiteSpace(leaveRequestVM.FromDate.ToString()) || string.IsNullOrWhiteSpace(leaveRequestVM.ToDate.ToString()) ||
               string.IsNullOrWhiteSpace(leaveRequestVM.Reason) || string.IsNullOrWhiteSpace(leaveRequestVM.ApproverComments) || string.IsNullOrWhiteSpace(leaveRequestVM.Status) ||
               string.IsNullOrWhiteSpace(leaveRequestVM.Employee.ToString()) || string.IsNullOrWhiteSpace(leaveRequestVM.Category.ToString()))
            {
                return status;
            }
            else
            {
                var result = _leaveRequestRepository.Update(id,leaveRequestVM);
                return result;

            }
        }
    }
}

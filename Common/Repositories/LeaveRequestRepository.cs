using Common.Repositories.Interfaces;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Repositories
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        bool status = false;
        ApplicationContext aplicationContext = new ApplicationContext();
        public bool Delete(int id)
        {

            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                aplicationContext.Entry(get).State = EntityState.Modified;
                var result = aplicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<LeaveRequest> Get()
        {
            var get = aplicationContext.LeaveRequests
                .Include("Employee")
                .Include("Category").Where(x => x.IsDelete == false && x.Status.Equals("Pending")).ToList();
            return get;
        }

        //public List<LeaveRequest> Get(string value)
        //{
        //     var get = aplicationContext.LeaveRequests.Where(x => (x.Id.ToString().Contains(value) || x.FromDate.ToString().Contains(value)|| x.ToDate.ToString().Contains(value)|| x.Reason.Contains(value) 
        //     || x.ApproverComments.Contains(value) || x.Status.Contains(value)) && x.IsDelete == false).ToList(); 
        //    return get;
        //}

        public LeaveRequest Get(int id)
        {
            var get = aplicationContext.LeaveRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }
        
        public bool Insert(LeaveRequestVM leaveRequestVM)
        {
            var push = new LeaveRequest(leaveRequestVM);
            var getEmployee = aplicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveRequestVM.Employee);
            push.Employee = getEmployee;
            var getCategory = aplicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveRequestVM.Category);
            push.Category = getCategory; 
            aplicationContext.LeaveRequests.Add(push);
            var result = aplicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, LeaveRequestVM leaveRequestVM)
        {
            var get = Get(id);
            if (get != null)
            {
                var getEmployee = aplicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveRequestVM.Employee);
                get.Employee = getEmployee;
                var getCategory = aplicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveRequestVM.Category);
                get.Category = getCategory;
                get.Update(leaveRequestVM);
                aplicationContext.Entry(get).State = EntityState.Modified;
                var result = aplicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}

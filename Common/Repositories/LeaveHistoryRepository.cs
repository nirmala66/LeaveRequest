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
    public class LeaveHistoryRepository : ILeaveHistoryRepository
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

        public List<LeaveHistory> Get()
        {
            var get = aplicationContext.LeaveHistories
                .Include("Employee")
                .Include("Category").Where(x => x.IsDelete == false && x.Status!="Pending").ToList();
            return get;
        }

        //public List<LeaveHistory> Get(string value)
        //{
        //    var get = aplicationContext.LeaveHistories.Where(x => (x.Id.ToString().Contains(value) || x.FromDate.ToString().Contains(value) || x.ToDate.ToString().Contains(value) || x.Reason.Contains(value)
        //    || x.ApproverComments.Contains(value) || x.Status.Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public LeaveHistory Get(int id)
        {
            var get = aplicationContext.LeaveHistories.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(LeaveHistoryVM leaveHistoryVM)
        {
            var push = new LeaveHistory(leaveHistoryVM);
            var getEmployee = aplicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveHistoryVM.Employee);
            push.Employee = getEmployee;
            var getCategory = aplicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveHistoryVM.Category);
            push.Category = getCategory;
            aplicationContext.LeaveHistories.Add(push);
            var result = aplicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, LeaveHistoryVM leaveHistoryVM)
        {
            var get = Get(id);
            if (get != null)
            {
                var getEmployee = aplicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveHistoryVM.Employee);
                get.Employee = getEmployee;
                var getCategory = aplicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == leaveHistoryVM.Category);
                get.Category = getCategory;
                get.Update(leaveHistoryVM);
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

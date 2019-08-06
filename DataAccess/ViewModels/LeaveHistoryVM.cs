using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LeaveHistoryVM
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate {get;set;}
        public string Reason { get; set; }
        public string ApproverComments { get; set; }
        public string Status { get; set; }
        public int Employees { get; set; }
        public int Leave_Categories { get; set; } 

        public LeaveHistoryVM(DateTime? fromdate, DateTime? todate, string reason, string approvercomments, string status, int employeesid,int leavecategoriesid)
        {
            this.FromDate = fromdate;
            this.ToDate = todate;
            this.Reason = reason;
            this.ApproverComments = approvercomments;
            this.Status = status;
            this.Employees = employeesid;
            this.Leave_Categories = leavecategoriesid;
        }
     
        public void Update(DateTime? fromdate, DateTime? todate, string reason, string approvercomments, string status, int employeesid, int leavecategoriesid)
        {
            this.FromDate = fromdate;
            this.ToDate = todate;
            this.Reason = reason;
            this.ApproverComments = approvercomments;
            this.Status = status;
            this.Employees = employeesid;
            this.Leave_Categories = leavecategoriesid;
        }
       
       
    }
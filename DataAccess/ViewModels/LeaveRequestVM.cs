using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LeaveRequestVM
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate {get;set;}
        public string Reason { get; set; }
        public string ApproverComments { get; set; }
        public string Status { get; set; }
        public int Employee { get; set; }//foreign key
        public int Category { get; set; } 

        public LeaveRequestVM(DateTime? fromDate, DateTime? toDate, string reason, string approverComments, string status, int employeesId,int CategoryId)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Reason = reason;
            this.ApproverComments = approverComments;
            this.Status = status;
            this.Employee = employeesId;
            this.Category = CategoryId;
        }
     
        public void Update(DateTime? fromDate, DateTime? toDate, string reason, string approverComments, string status, int employeesId, int CategoryId)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Reason = reason;
            this.ApproverComments = approverComments;
            this.Status = status;
            this.Employee = employeesId;
            this.Category = CategoryId;
        }
       
       
    }
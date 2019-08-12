using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_LeaveHistory")]
    public class LeaveHistory : BaseModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Reason { get; set; }
        public string ApproverComments { get; set; }
        public string Status { get; set; }
        public Category Category { get; set; }
        public Employee Employee { get; set; }

        public LeaveHistory(LeaveHistoryVM leavehistoryVM)
        {
            this.FromDate = leavehistoryVM.FromDate;
            this.ToDate = leavehistoryVM.ToDate;
            this.Reason = leavehistoryVM.Reason;
            this.ApproverComments = leavehistoryVM.ApproverComments;
            this.Status = leavehistoryVM.Status;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public LeaveHistory() { }

        public void Update(LeaveHistoryVM leavehistoryVM)
        {
            this.FromDate = leavehistoryVM.FromDate;
            this.ToDate = leavehistoryVM.ToDate;
            this.Reason = leavehistoryVM.Reason;
            this.ApproverComments = leavehistoryVM.ApproverComments;
            this.Status = leavehistoryVM.Status;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
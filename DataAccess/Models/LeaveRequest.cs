using Core.Base;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LeaveRequest: BaseModel
{
    public DateTime? FromDate{get;set;}
    public DateTime? ToDate{get;set;}
    public string Reason{get;set;}
    public string ApproverComments{get;set;}
    public String Status{get;set;}
    public Category Category {get;set;}
    public Employee Employee{get;set;}

    public LeaveRequest(LeaveRequestVM leaverequestVM)
    {
        this.FromDate=leaverequestVM.FromDate;
        this.ToDate=leaverequestVM.ToDate;
        this.Reason=leaverequestVM.Reason;
        this.ApproverComments=leaverequestVM.ApproverComments;
        this.Status=leaverequestVM.Status;
        this.CreateDate=DateTimeOffset.Now.LocalDateTime;
    }

    public void Update(LeaveRequestVM leaverequestVM)
    {
        this.FromDate=leaverequestVM.FromDate;
        this.ToDate=leaverequestVM.ToDate;
        this.Reason=leaverequestVM.Reason;
        this.ApproverComments=leaverequestVM.ApproverComments;
        this.Status=leaverequestVM.Status;
        this.UpdateDate=DateTimeOffset.Now.LocalDateTime;
    }

    public void Delete()
    {
        this.IsDelete=true;
        this.DeleteDate=DateTimeOffset.Now.LocalDateTime;
    }

}
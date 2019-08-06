using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class EmployeeStatus : BaseModel
    {
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }

        public EmployeeStatus() { }

        public EmployeeStatus(EmployeeStatusVM employeestatusVM)
        {
            this.JoinDate = employeestatusVM.JoinDate;
            this.EndDate = employeestatusVM.EndDate;
            this.Status = employeestatusVM.Status;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        //public Update(EmployeeStatusVM employeestatusVM)
        //{
            //this.JoinDate = employeestatusVM.JoinDate;
            //this.EndDate = employeestatusVM.EndDate;
            //this.Status = employeestatusVM.Status;
            //this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        //}

        //public Delete(EmployeeStatusVM employeestatusVM)
        //{
            //this.IsDelete = true;
            //this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeStatusVM
    {
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }

        public EmployeeStatusVM() { }

        public EmployeeStatusVM(DateTime? JoinDate, DateTime? EndDate, string Status)
        {
            this.JoinDate = JoinDate;
            this.EndDate = EndDate;
            this.Status = Status;
        }

        public void Update(DateTime? JoinDate, DateTime? EndDate, string Status)
        {
            this.JoinDate = JoinDate;
            this.EndDate = EndDate;
            this.Status = Status;
        }
    }
}

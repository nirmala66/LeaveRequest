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
    [Table("TB_M_Employee")] // Ini hanya untuk penamaan di Database
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Religion { get; set; }
        public string Marital_Status { get; set; }
        public string Num_Of_Children { get; set; }

        public Employee Manager { get; set; } // Self Join

        public Department Department { get; set; } // Join

        public Village Village { get; set; } // Join

        public Position Position { get; set; } // Join

        public Employee() { }

        public Employee(EmployeeVM employeeVM)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Gender = employeeVM.Gender;
            this.Religion = employeeVM.Religion;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Num_Of_Children = employeeVM.Num_Of_Children;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Update(EmployeeVM employeeVM)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Gender = employeeVM.Gender;
            this.Religion = employeeVM.Religion;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Num_Of_Children = employeeVM.Num_Of_Children;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}

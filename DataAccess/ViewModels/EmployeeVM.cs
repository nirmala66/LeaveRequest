using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Religion { get; set; }
        public string Marital_Status { get; set; }
        public string Num_Of_Children { get; set; }

        public int Manager_Id { get; set; }

        public int Department_Id { get; set; }

        public int Village_Id { get; set; }

        public int Position_Id { get; set; }

        public EmployeeVM() { } // constructor

        public EmployeeVM(string firstname, string lastname, bool gender, string religion, string marital_status, string num_of_children, int manager_Id, int department_Id, int village_Id, int position_Id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.Religion = religion;
            this.Marital_Status = marital_status;
            this.Num_Of_Children = num_of_children;
            this.Manager_Id = manager_Id;
            this.Department_Id = department_Id;
            this.Village_Id = village_Id;
            this.Position_Id = position_Id;
        }

        public void Update(string firstname, string lastname, bool gender, string religion, string marital_status, string num_of_children, int manager_Id, int department_Id, int village_Id, int position_Id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.Religion = religion;
            this.Marital_Status = marital_status;
            this.Num_Of_Children = num_of_children;
            this.Manager_Id = manager_Id;
            this.Department_Id = department_Id;
            this.Village_Id = village_Id;
            this.Position_Id = position_Id;
        }
    }
}

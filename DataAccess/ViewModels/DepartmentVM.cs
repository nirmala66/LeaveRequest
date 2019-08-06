using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DepartmentVM
    {
        public string Name { get; set; }

        
		public int Division_Id { get; set; }
      
        public DepartmentVM(string name, int division_id)
        {
            this.Name = name;
            this.Division_Id = division_id;
        }
    }
}

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

        public int Divisi_Id { get; set; }

        public DepartmentVM(string name, int divisi_Id)
        {
            this.Name = name;
            this.Divisi_Id = divisi_Id;
        }
    }
}

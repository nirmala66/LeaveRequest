using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RegencyVM
    {
        public string Name { get; set; }
        public int Province_Id { get; set; }

        public RegencyVM(string name, int province_Id)
        {
            this.Name = name;
            this.Province_Id = province_Id;
        }
    }
}

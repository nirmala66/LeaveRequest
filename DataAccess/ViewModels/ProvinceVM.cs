using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ProvinceVM
    {
        public string Name { get; set; }

        public ProvinceVM(string name)
        {
            this.Name = name;
        }
    }
}

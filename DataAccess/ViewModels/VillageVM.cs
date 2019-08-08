using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class VillageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int District_Id { get; set; }

        public VillageVM(string name, int district_Id)
        {
            this.Name = name;
            this.District_Id = district_Id;
        }
    }
}

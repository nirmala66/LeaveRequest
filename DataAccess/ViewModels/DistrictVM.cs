using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DistrictVM
    {
        public string Name { get; set; }
        public int Regency_Id { get; set; }

        public DistrictVM(string name, int regency_Id)
        {
            this.Name = name;
            this.Regency_Id = regency_Id;
        }
    }
}

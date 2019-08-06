using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ParameterVM
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public ParameterVM() { }

        public ParameterVM(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public void Update(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class CategoryVM
    {
        private CategoryVM categoryVM;

        public string Name { get; set; }
        public int TotalDays { get; set; }
        public string Description { get; set; }

        public CategoryVM() { }

        public CategoryVM(string Name, int TotalDays, string Description)
        {
            this.Name = Name;
            this.TotalDays = TotalDays;
            this.Description = Description;
        }

        public CategoryVM(CategoryVM categoryVM)
        {
            this.Name = Name;
            this.TotalDays = TotalDays;
            this.Description = Description;
        }

        public void Update(string Name, int TotalDays, string Description)
        {
            this.Name = Name;
            this.TotalDays = TotalDays;
            this.Description = Description;
        }
    }
}

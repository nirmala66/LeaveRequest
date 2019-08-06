using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class AvailableLeaveVM
    {
        public string LastYear { get; set; }
        public string ThisYear { get; set; }

        public AvailableLeaveVM() { }

        public AvailableLeaveVM(string LastYear, string ThisYear)
        {
            this.LastYear = LastYear;
            this.ThisYear = ThisYear;
        }

        public void Update(string LastYear, string ThisYear)
        {
            this.LastYear = LastYear;
            this.ThisYear = ThisYear;
        }
    }
}

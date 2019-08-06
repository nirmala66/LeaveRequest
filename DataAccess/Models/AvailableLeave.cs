using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class AvailableLeave : BaseModel
    {
        public string LastYear { get; set; }
        public string ThisYear { get; set; }

        public AvailableLeave() { }
        public AvailableLeave(AvailableLeaveVM availableleaveVM)
        {
            this.LastYear = availableleaveVM.LastYear;
            this.ThisYear = availableleaveVM.ThisYear;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(AvailableLeaveVM availableleaveVM)
        {
            this.LastYear = availableleaveVM.LastYear;
            this.ThisYear = availableleaveVM.ThisYear;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete(AvailableLeaveVM availableleaveVM)
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}

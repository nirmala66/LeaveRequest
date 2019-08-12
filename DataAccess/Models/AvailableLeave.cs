using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_AvailableLeave")]
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

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}

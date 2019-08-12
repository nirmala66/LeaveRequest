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
    [Table("TB_M_Regency")]
    public class Regency : BaseModel
    {
        public string Name { get; set; }

        [ForeignKey("Province")]
        public int Province_Id { get; set; }
        public Province Province { get; set; }

        public Regency() { }

        public Regency(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        //public virtual void Update(RegencyVM regencyVM)
        //{
        //    this.Id = regencyVM.Id;
        //    this.Name = regencyVM.Name;
        //    this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        //}

        //public virtual void Delete()
        //{
        //    this.IsDelete = true;
        //    this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        //}
    }
}

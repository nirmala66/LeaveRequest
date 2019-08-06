﻿using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Province")]
    public class Province : BaseModel
    {
        public string Name { get; set; }

        public Province() { }

        public Province(ProvinceVM provinceVM)
        {
            this.Name = provinceVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        //public virtual void Update(ProvinceVM provinceVM)
        //{
        //    this.Id = provinceVM.Id;
        //    this.Name = provinceVM.Name;
        //    this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        //}

        //public virtual void Delete()
        //{
        //    this.IsDelete = true;
        //    this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        //}
    }
}

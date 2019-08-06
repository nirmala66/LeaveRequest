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
    [Table("TB_M_Divisi")]
    public class Division : BaseModel
    {
        public string Name { get; set; }

        public Division() { }

        public Division(DivisionVM divisionVM)
        {
            this.Name = divisionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        //public void Update(DivisiVM divisiVM) // Pembuatan Constructor untuk Update
        //{
        //    this.Name = divisiVM.Name;
        //    this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        //}
        //public void Delete() // Pembuatan Constructor untuk Delete
        //{
        //    this.IsDelete = true;
        //    this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        //}
    }
}

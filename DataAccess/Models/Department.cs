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
    [Table("TB_M_Department")]
    public class Department : BaseModel
    {
        public string Name { get; set; }

        public Divisi Divisi { get; set; }

        public Department() { }
        public Department(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        //public void Update(DepartmentVM departmentVM) // Pembuatan Constructor untuk Update
        //{
        //    this.Name = departmentVM.Name;
        //    this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        //}
        //public void Delete() // Pembuatan Constructor untuk Delete
        //{
        //    this.IsDelete = true;
        //    this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        //}
    }
}

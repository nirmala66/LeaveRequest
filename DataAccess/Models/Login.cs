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
    [Table("TB_M_Login")]
    public class Login : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Disband { get; set; }
        public Role Role { get; set; }

        public Login() { }
        public Login(LoginVM loginVM)
        {
            this.Email = loginVM.Email;
            this.Password = loginVM.Password;
            this.Disband = loginVM.Disband;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(LoginVM loginVM)
        {
            this.Email = loginVM.Email;
            this.Password = loginVM.Password;
            this.Disband = loginVM.Disband;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;

        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}

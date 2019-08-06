using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class LoginVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Disband { get; set; }
        public int Role_Id { get; set; }

        public LoginVM() { }
        public LoginVM(string email, string password, int disband, int role_Id)
        {
            this.Email = email;
            this.Password = password;
            this.Disband = disband;
            this.Role_Id = role_Id;
        }

        public void Update(string email, string password, int disband, int role_Id)
        {
            this.Email = email;
            this.Password = password;
            this.Disband = disband;
            this.Role_Id = role_Id;
        }
    }
}

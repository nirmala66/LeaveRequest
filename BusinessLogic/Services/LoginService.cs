using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class LoginService : ILoginService
    {
        bool status = false;

        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public LoginService() { }
        public List<Login> Get()
        {
            var result = _loginRepository.Get();
            return result;
        }

        public Login Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _loginRepository.Get(id);
                return result;
            }
        }

        public bool Insert(LoginVM loginVM)
        {
            if (string.IsNullOrWhiteSpace(loginVM.Email) || string.IsNullOrWhiteSpace(loginVM.Password) || string.IsNullOrWhiteSpace(loginVM.Disband.ToString()) || string.IsNullOrWhiteSpace(loginVM.Role_Id.ToString()))
            {
                return false;
            }
            else
            {
                var result = _loginRepository.Insert(loginVM);
                return result;
            }
        }
    }
}

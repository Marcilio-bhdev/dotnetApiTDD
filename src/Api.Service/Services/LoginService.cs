using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindbyLogin(UserEntity user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                return await _repository.FindbyLogin(user.Email);
            }
            else
            {
                return null;
            }


        }
    }
}

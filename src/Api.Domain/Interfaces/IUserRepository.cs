using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        public Task<UserEntity> FindbyLogin(string email);
    }
}

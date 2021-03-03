using System;
using System.Collections.Generic;
using devFglDemo.Domain.Entities;

namespace devFglDemo.Application.Contracts
{
    public interface IUserV2Repository : IRepository<User>
    {

        bool EmailExists(string email);
        bool UserExists(Guid id);
    }
}

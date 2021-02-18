using System;
using System.Collections.Generic;
using devFglDemo.Domain.Entities;

namespace devFglDemo.Application.Contracts
{
    public interface IUserRepository
    {

        IEnumerable<User> GetAll();
        User GetById(Guid id);
        void Save(User user);
        void Edit(User user);
        void Delete(User user);

        bool EmailExists(string email);
        bool UserExists(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using devDemo.Infra.DataContext;
using devFglDemo.Application.Contracts;
using devFglDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace devDemo.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DemoContext _demoCtx;

        public UserRepository(DemoContext demoCtx)
        {
            _demoCtx = demoCtx;
        }

        public IEnumerable<User> GetAll()
        {
            var all = _demoCtx.Users.AsNoTracking().Where(x => x.IsActive == true)
            .OrderBy(x => x.Name);

            return all;
        }
        public User GetById(Guid id)
        {
            var user = _demoCtx.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        public void Save(User user)
        {
            _demoCtx.Users.Add(user);
            _demoCtx.SaveChanges();
        }
        public void Edit(User user)
        {
            _demoCtx.Entry<User>(user).State = EntityState.Modified;
            _demoCtx.SaveChanges();
        }
        public void Delete(User user)
        {
            _demoCtx.Entry<User>(user).State = EntityState.Deleted;
            _demoCtx.SaveChanges();
        }


        public bool EmailExists(string email)
        {
            var sql = _demoCtx.Users.Any(x => x.Email == email);
            return sql;
        }

        public bool UserExists(Guid id)
        {
            var user = _demoCtx.Users.Any(x => x.Id == id);
            return user;
        }
    }
}

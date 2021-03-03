using System;
using System.Collections.Generic;
using System.Linq;
using devDemo.Infra.DataContext;
using devFglDemo.Application.Contracts;
using devFglDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace devDemo.Infra.Repositories
{
    public class UserV2Repository : Repository<User>, IUserV2Repository
    {
        private readonly DemoContext _demoCtx;
        private readonly DbSet<User> _users;

        public UserV2Repository(DemoContext demoCtx) : base(demoCtx)
        {
            _demoCtx = demoCtx;
            _users = _demoCtx.Set<User>();
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

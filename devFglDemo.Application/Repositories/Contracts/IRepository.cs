using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using devFglDemo.Domain.Entities.Base;

namespace devFglDemo.Application.Contracts
{
    public interface IRepository<T> where T : DomainBase
    {
        void Create(T entity);
        void Delete(T entity);
        void Delete(Guid id);
        void Edit(T entity);

        //read side (could be in separate Readonly Generic Repository)
        T GetById(Guid id);
        IEnumerable<T> Filter();
        IEnumerable<T> Filter(Func<T, bool> predicate);

        //separate method SaveChanges can be helpful when using this pattern with UnitOfWork
        void SaveChanges();
    }
}
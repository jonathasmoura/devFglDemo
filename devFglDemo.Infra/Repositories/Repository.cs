using System;
using System.Collections.Generic;
using System.Linq;
using devDemo.Infra.DataContext;
using devFglDemo.Application.Contracts;
using devFglDemo.Domain.Entities.Base;

namespace devDemo.Infra.Repositories
{
    public class Repository<T> : IRepository<T>, IDisposable where T : DomainBase
    {
        private readonly DemoContext _demoCtx;

        public Repository(DemoContext demoCtx)
        {
            _demoCtx = demoCtx;
        }

        public IEnumerable<T> All()
        {
            return _demoCtx.Set<T>();
        }

        public T GetById(Guid id)
        {
            var editedEntity = _demoCtx.Set<T>().FirstOrDefault(x => x.Id == id);
            return editedEntity;
        }

        public void Create(T entity)
        {
            _demoCtx.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _demoCtx.Set<T>().Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entityToDelete = _demoCtx.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entityToDelete != null)
            {
                _demoCtx.Set<T>().Remove(entityToDelete);
            }
        }

        public void Edit(T entity)
        {
            var editedEntity = _demoCtx.Set<T>().FirstOrDefault(x => x.Id == entity.Id);
            editedEntity = entity;
        }

        public IEnumerable<T> Filter()
        {
            return _demoCtx.Set<T>();
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _demoCtx.Set<T>().Where(predicate);
        }
        public void SaveChanges() => _demoCtx.SaveChanges();

        public void Dispose()
        {
            if (_demoCtx != null)
            {
                _demoCtx.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}

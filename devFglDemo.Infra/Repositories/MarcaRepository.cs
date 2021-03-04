using System;
using System.Collections.Generic;
using System.Linq;
using devDemo.Infra.DataContext;
using devFglDemo.Application.Contracts;
using devFglDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace devDemo.Infra.Repositories
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        private readonly DemoContext _demoCtx;
        public MarcaRepository(DemoContext demoCtx) : base(demoCtx)
        {
            _demoCtx = demoCtx;
        }

        public bool ExisteMarca(string marca)
        {
            var sql = _demoCtx.Marcas.Any(x => x.Name == marca);
            return sql;
        }
    }
}

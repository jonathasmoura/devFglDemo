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
        public MarcaRepository(DemoContext demoCtx) : base(demoCtx)
        {
        }

        public bool ExisteMarca(string marca)
        {
            throw new NotImplementedException();
        }
    }
}

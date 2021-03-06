using devFglDemo.Domain.Entities;

namespace devFglDemo.Application.Contracts
{
    public interface IMarcaRepository : IRepository<Marca>
    {
        bool ExisteMarca(string marca);
    }
}

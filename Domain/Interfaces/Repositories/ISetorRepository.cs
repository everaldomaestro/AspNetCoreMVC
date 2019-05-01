using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface ISetorRepository : IRepositoryBase<Setor>
    {
        IEnumerable<Setor> GetByNome(string nome);
    }
}

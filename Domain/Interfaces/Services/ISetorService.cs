using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface ISetorService : IServiceBase<Setor>
    {
        IEnumerable<Setor> GetByNome(string nome);
    }
}

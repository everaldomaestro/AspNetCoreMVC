using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using System.Linq;

namespace Infra.Repositories
{
    public class SetorRepository : RepositoryBase<Setor>, ISetorRepository
    {
        public SetorRepository(NotiLigaContext context) : base(context)
        {
        }

        public IEnumerable<Setor> GetByNome(string nome)
        {
            return Db.Setores.Where(s => s.Nome.ToLower().Contains(nome.ToLower()));
        }
    }
}

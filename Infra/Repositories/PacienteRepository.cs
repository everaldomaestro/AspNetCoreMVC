using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;

namespace Infra.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
        public PacienteRepository(NotiLigaContext context) : base(context)
        {
        }

        public IEnumerable<Paciente> GetByNome(string nome)
        {
            return Db.Pacientes.Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }
    }
}

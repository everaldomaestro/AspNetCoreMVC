using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IPacienteRepository : IRepositoryBase<Paciente>
    {
        IEnumerable<Paciente> GetByNome(string nome);
    }
}

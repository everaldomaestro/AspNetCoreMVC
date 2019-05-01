using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IPacienteService : IServiceBase<Paciente>
    {
        IEnumerable<Paciente> GetByNome(string nome);
    }
}

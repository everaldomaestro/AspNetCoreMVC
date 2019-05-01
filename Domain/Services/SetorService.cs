using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class SetorService : ServiceBase<Setor> , ISetorService
    {
        private readonly ISetorRepository _setorRepository;

        public SetorService(ISetorRepository setorRepository) : base (setorRepository)
        {
            _setorRepository = setorRepository;
        }

        public IEnumerable<Setor> GetByNome(string nome)
        {
            return _setorRepository.GetByNome(nome);
        }
    }
}

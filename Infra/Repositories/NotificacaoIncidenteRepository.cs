using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;

namespace Infra.Repositories
{
    public class NotificacaoIncidenteRepository : RepositoryBase<NotificacaoIncidente>, INotificacaoIncidenteRepository
    {
        public NotificacaoIncidenteRepository(NotiLigaContext context) : base(context)
        {
        }
    }
}

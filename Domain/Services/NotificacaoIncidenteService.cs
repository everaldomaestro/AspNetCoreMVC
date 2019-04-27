using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class NotificacaoIncidenteService : ServiceBase<NotificacaoIncidente> , INotificacaoIncidenteService
    {
        private readonly INotificacaoIncidenteRepository _notificacaoIncidenteRepository;

        public NotificacaoIncidenteService(INotificacaoIncidenteRepository notificacaoIncidenteRepository)
            : base(notificacaoIncidenteRepository)
        {
            _notificacaoIncidenteRepository = notificacaoIncidenteRepository;
        }
    }
}

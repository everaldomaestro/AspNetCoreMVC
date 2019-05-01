using AspNET.MVC.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace AspNET.MVC.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<NotificacaoIncidenteViewModel, NotificacaoIncidente>()
                .ForMember(model=> model.NotificacaoIncidenteId, bind=> bind.Ignore());
        }
    }
}

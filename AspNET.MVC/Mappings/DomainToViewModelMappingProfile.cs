using AspNET.MVC.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace AspNET.MVC.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<NotificacaoIncidente, NotificacaoIncidenteViewModel>()
                .ForMember(viewModel => viewModel.NomeSetor,
                    bind => bind.MapFrom(model => model.Setores.Nome))
                        .ReverseMap()
                            .ForPath(model => model.Setores.Nome,
                                bind => bind.MapFrom(viewModel => viewModel.NomeSetor));
        }
    }
}

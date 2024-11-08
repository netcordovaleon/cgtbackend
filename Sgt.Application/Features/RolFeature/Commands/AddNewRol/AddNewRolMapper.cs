using AutoMapper;
using Sgt.Domain.Entities;

namespace Sgt.Application.Features.RolFeature.Commands.AddNewRol;

public class AddNewRolMapper : Profile
{
    public AddNewRolMapper()
    {
        CreateMap<AddNewRolRequest, RolEntity>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.RegisterState, opt => opt.MapFrom(src => true)).ReverseMap();
        CreateMap<RolEntity, AddNewRolResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();
    }
}

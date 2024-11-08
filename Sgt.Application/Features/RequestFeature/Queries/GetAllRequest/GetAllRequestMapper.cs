using AutoMapper;
using Sgt.Domain.Entities;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequest;

public class GetAllRequestMapper : Profile
{
    public GetAllRequestMapper()
    {
        CreateMap<GetAllRequestRequest, RequestEntity>().ReverseMap();
        CreateMap<RequestEntity, GetAllRequestResponse>()
        .ForMember(dest => dest.RequestStatus, opt => opt.MapFrom(src => src.RequestStatus.ToString()))
        .ForMember(dest => dest.RequestStart, opt => opt.MapFrom(src => src.RequestStart!.Value.ToString("dd/MM/yyyy")))
        .ForMember(dest => dest.RequestEnd, opt => opt.MapFrom(src => src.RequestEnd!.Value.ToString("dd/MM/yyyy")))

        .ReverseMap();
    }
}

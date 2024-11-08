
using AutoMapper;
using Sgt.Domain.Entities;

namespace Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;

public class AddNewRequestMapper : Profile
{
	public AddNewRequestMapper()
	{
        CreateMap<AddNewRequestRequest, RequestEntity>().ReverseMap();
        CreateMap<RequestEntity, AddNewRequestResponse>().ReverseMap();

    }

}


using AutoMapper;
using MediatR;
using Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;
using Sgt.Application.Repository;

namespace Sgt.Application.Features.RequestFeature.Queries.GetAllRequest;

public class GetAllRequestHandler : IRequestHandler<GetAllRequestRequest, List<GetAllRequestResponse>>
{
    private readonly IMapper _mapper;
    private readonly IRequestRepository _requestRepository;
    public GetAllRequestHandler(IRequestRepository requestRepository, IMapper mapper)
    {
        _requestRepository = requestRepository;
        _mapper = mapper;
    }
    public async Task<List<GetAllRequestResponse>> Handle(GetAllRequestRequest request, CancellationToken cancellationToken)
    {
        var listToDb = await _requestRepository.GetAllAsync();
        var result = _mapper.Map<List<GetAllRequestResponse>>(listToDb);
        return result;
    }
}

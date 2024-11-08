using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;
using Sgt.Application.Features.RequestFeature.Queries.GetAllRequest;
using Sgt.Application.Features.RequestFeature.Queries.GetAllRequestStatusType;

namespace Sgt.App.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RequestController : ControllerBase
{
    private readonly IMediator _mediator;
    public RequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("types")]
    public async Task<List<GetAllRequestStatusTypeResponse>> GetStatusType() {
        var result = await _mediator.Send(new GetAllRequestStatusTypeRequest());
        return result;
    }

    [HttpPost]
    [Route("")]
    public async Task<AddNewRequestResponse> AddNewRequest(AddNewRequestRequest request)
    {
        var result = await _mediator.Send(request);
        return result;
    }

    [HttpGet]
    [Route("")]
    public async Task<List<GetAllRequestResponse>> GetAllRequest()
    {
        var result = await _mediator.Send(new GetAllRequestRequest());
        return result;
    }
}

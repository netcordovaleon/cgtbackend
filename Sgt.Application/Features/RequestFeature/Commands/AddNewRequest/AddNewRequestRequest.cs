using MediatR;
using Sgt.Shared.EnumValues;
using System;

namespace Sgt.Application.Features.RequestFeature.Commands.AddNewRequest;

public sealed record AddNewRequestRequest : IRequest<AddNewRequestResponse>
{
    public DateTime? RequestStart { get; set; }
    public DateTime? RequestEnd { get; set; }
    public int? HoursRequested { get; set; }
    public string? Description { get; set; }
    public RequestStatusType? RequestStatus { get; set; }
    public string? RequestingUserId { get; set; }
    public string? ReviewerUserId { get; set; }
}

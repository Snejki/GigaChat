using System.Text.Json;
using System.Text.Json.Serialization;
using GigaChat.Application.Features.Chat;
using GigaChat.Application.Tools.Chat;
using GigaChat.Application.Tools.Youtube;
using MediatR;

namespace GigaChat.Api.Endpoints;

static class ChatEndpoints
{
    public static IEndpointRouteBuilder AddChatEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("api/chat", async (IMediator mediator, GetChatResponseQuery query) => await mediator.Send(query));
        
        return routes;
    }    
}
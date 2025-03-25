using GigaChat.Application.Features.Chat;
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
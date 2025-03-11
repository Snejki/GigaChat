using GigaChat.Application.Tools.Chat;
using MediatR;
using Microsoft.Extensions.AI;

namespace GigaChat.Application.Features.Chat;

public class ChatApiMessage
{
    public string Role { get; set; }
    public string Content { get; set; }
}

public class ChatApiOptions
{
    public string Model { get; set; }
    public string Engine { get; set; }
    public string Temperature { get; set; }
    public string MaxTokens { get; set; }
    public string TopP { get; set; }
    public string FrequencyPenalty { get; set; }
    public string PresencePenalty { get; set; }
    public string Stop { get; set; }
}

public class ChatApiResponse
{
}

public record GetChatResponseQuery(List<ChatApiMessage> Messages) : IRequest<ChatResponse>;

public class GetChatResponseQueryHandler : IRequestHandler<GetChatResponseQuery, ChatResponse>
{
    private readonly IChatApiClientProvider _chatApiClientProvider;

    public GetChatResponseQueryHandler(IChatApiClientProvider chatApiClientProvider)
    {
        _chatApiClientProvider = chatApiClientProvider;
    }

    public async Task<ChatResponse> Handle(GetChatResponseQuery request, CancellationToken cancellationToken)
    {
        var client = _chatApiClientProvider.Provide("openai", "gpt-4o");
        await client.GetResponse(request.Messages, new ChatApiOptions());

        return null;
    }
}
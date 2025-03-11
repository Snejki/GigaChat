using GigaChat.Application.Features.Chat;
using GigaChat.Application.Tools.Chat;
using Microsoft.Extensions.AI;
using OpenAI;

namespace GigaChat.Infrastructure.Chat;

public class OpenAiAPiClient : IChatAPiClient
{
    public string ProviderName => "openai";

    public async Task<ChatApiResponse> GetResponse(List<ChatApiMessage> messages, ChatApiOptions options)
    {
        var apiKey = "";
        var model  = "gpt-4o";
        var client = new OpenAIClient(apiKey).AsChatClient(model);
        var response = await client.GetResponseAsync(MapMessages(messages));

        return MapResponse(response);
    }

    private List<Microsoft.Extensions.AI.ChatMessage> MapMessages(List<ChatApiMessage> messages)
    {
        var response = new List<Microsoft.Extensions.AI.ChatMessage>();

        foreach (var message in messages)
        {
            response.Add(new Microsoft.Extensions.AI.ChatMessage(ChatRole.System, message.Content));
        }
        
        return response;
    }

    private ChatApiResponse MapResponse(ChatResponse response)
    {
        return new ChatApiResponse()
        {

        };
    }
}
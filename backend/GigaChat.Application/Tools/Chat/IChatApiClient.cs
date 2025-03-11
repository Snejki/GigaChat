using GigaChat.Application.Features.Chat;
using Microsoft.Extensions.AI;

namespace GigaChat.Application.Tools.Chat;

public interface IChatAPiClient
{
    public string ProviderName { get; }
    Task<ChatApiResponse> GetResponse(List<ChatApiMessage> messages, ChatApiOptions options);
}
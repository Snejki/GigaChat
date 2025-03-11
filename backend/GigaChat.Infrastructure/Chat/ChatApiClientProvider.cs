using GigaChat.Application.Tools.Chat;

namespace GigaChat.Infrastructure.Chat;

public class ChatApiClientProvider : IChatApiClientProvider
{
    private readonly IEnumerable<IChatAPiClient> _clients;

    public ChatApiClientProvider(IEnumerable<IChatAPiClient> clients)
    {
        _clients = clients;
    }

    public IChatAPiClient Provide(string provider, string model)
    {
        var client = _clients.FirstOrDefault(x => x.ProviderName == provider);
        if (client is null)
        {
            throw new Exception("Missing chat provider");
        }

        return client;
    }
}
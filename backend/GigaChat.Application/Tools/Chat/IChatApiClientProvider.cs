namespace GigaChat.Application.Tools.Chat;

public interface IChatApiClientProvider
{
    IChatAPiClient Provide(string provider, string model);
}
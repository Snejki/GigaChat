using GigaChat.Api.Endpoints;
using GigaChat.Application.Features.Chat;
using GigaChat.Application.Tools.Chat;
using GigaChat.Application.Tools.Youtube;
using GigaChat.Infrastructure.Chat;
using GigaChat.Infrastructure.Tools.Youtube;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddTransient<IYoutubeTranscriptDownloader, YoutubeTranscriptDownloader>();
builder.Services.AddTransient<IChatAPiClient, OpenAiAPiClient>();
builder.Services.AddTransient<IChatApiClientProvider, ChatApiClientProvider>();
builder.Services.AddMediatR(opts => opts.RegisterServicesFromAssemblyContaining(typeof(GetChatResponseQuery)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.AddChatEndpoints();

app.UseHttpsRedirection();
app.Run();
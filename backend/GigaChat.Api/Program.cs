using GigaChat.Api.Endpoints;
using GigaChat.Application.Features.Chat;
using GigaChat.Application.Tools.Chat;
using GigaChat.Application.Tools.Youtube;
using GigaChat.Infrastructure.Chat;
using GigaChat.Infrastructure.Tools.Youtube;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddTransient<IYoutubeTranscriptDownloader, YoutubeTranscriptDownloader>();
builder.Services.AddTransient<IChatAPiClient, OpenAiAPiClient>();
builder.Services.AddTransient<IChatApiClientProvider, ChatApiClientProvider>();
builder.Services.AddMediatR(opts => opts.RegisterServicesFromAssemblyContaining(typeof(GetChatResponseQuery)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });

    app.AddChatEndpoints();

app.UseHttpsRedirection();
app.Run();
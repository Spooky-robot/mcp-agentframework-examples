using UserMgmtServer.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithPromptsFromAssembly()
    .WithTools<UserTools>();

var app = builder.Build();

app.MapMcp();

app.Run();

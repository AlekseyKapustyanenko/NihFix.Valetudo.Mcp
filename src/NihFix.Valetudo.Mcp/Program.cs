using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NihFix.Valetudo.Mcp;

var configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables();
var configuration = configurationBuilder.Build();
var serverType = configuration.GetSection(ValetudoMcpServerOptions.SectionName).GetValue<ServerType>(nameof(ValetudoMcpServerOptions.ServerType));
var app = serverType switch
{
    ServerType.Http => ValetudoMcpFactory.CreateSseServer(args),
    ServerType.Stdio => ValetudoMcpFactory.CreateStdioServer(args),
    _ => throw new ArgumentOutOfRangeException()
};

app.Run();
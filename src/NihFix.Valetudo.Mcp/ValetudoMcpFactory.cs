using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using NihFix.Valetudo.HttpClient;

namespace NihFix.Valetudo.Mcp;

public static class ValetudoMcpFactory
{
    public static IHost CreateSseServer(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Configuration.AddUserSecrets<Program>();
        builder.Services
            .AddValetudoHttpClient()
            .AddMcpServer()
            .WithHttpTransport();
        builder.Services.Configure<ValetudoMcpServerOptions>(
            builder.Configuration.GetSection(ValetudoMcpServerOptions.SectionName));

        var app = builder.Build();
        app.MapMcp();
        return app;
    }

    public static IHost CreateStdioServer(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        builder.Configuration.AddUserSecrets<Program>();
        builder.Services
            .AddValetudoHttpClient()
            .AddMcpServer()
            .WithStdioServerTransport();
        builder.Services.Configure<ValetudoMcpServerOptions>(
            builder.Configuration.GetSection(ValetudoMcpServerOptions.SectionName));
        
        var app = builder.Build();
        return app;
    }

    private static IServiceCollection AddValetudoHttpClient(this IServiceCollection services)
    {
        return services.AddSingleton<ValetudoClient>(serviceProvider =>
        {
            var options = serviceProvider.GetRequiredService<IOptions<ValetudoMcpServerOptions>>().Value;
            var requestAdapter = GetRequestAdapter(options);
            return new ValetudoClient(requestAdapter);
        });
    }

    private static HttpClientRequestAdapter GetRequestAdapter(ValetudoMcpServerOptions options)
    {
        var authProvider = new AnonymousAuthenticationProvider();
        HttpClientRequestAdapter adapter;
        if (options is { Username: not null, Password: not null })
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes($"{options.Username}:{options.Password}");
            var authString = System.Convert.ToBase64String(plainTextBytes);
            var httpClient = KiotaClientFactory.Create();
            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);
            adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        }
        else
        {
            adapter = new HttpClientRequestAdapter(authProvider);
        }
        adapter.BaseUrl = options.RobotUri;
        return adapter;
    }

    private static IMcpServerBuilder AddMcpServer(this IServiceCollection services)
    {
        return services
            .AddMcpServer(options =>
            {
                options.ServerInstructions = "This is MCP server that allows you to control vacuum robot.";
            })
            .WithTools<ValetudoTools>(JsonSerializerOptions.Web);
    }
}
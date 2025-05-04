using System.ComponentModel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ModelContextProtocol.Server;
using NihFix.Valetudo.HttpClient;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.BasicControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentationCapability;

namespace NihFix.Valetudo.Mcp;

[McpServerToolType]
public class ValetudoTools
{
    [McpServerTool(Name = "get-map-segments")]
    [Description(
        "Get available zones to vacuum robot for cleaning. Returns a list of segments with names and corresponding ids.")]
    public static async Task<List<MapSegmentationCapability>?> GetMapSegments(ValetudoClient client,
        CancellationToken cancellation)
    {
        return await client.Api.V2.Robot.Capabilities.MapSegmentationCapability.GetAsync(
            cancellationToken: cancellation);
    }

    [McpServerTool(Name = "clean-map-segments")]
    [Description(
        "Enforce vacuum robot to clean defined segments. Tip: To determine segments ids by their names you can call get-map-segments tool.")]
    public static async Task<string> CleanSegments(
        ValetudoClient client,
        [Description("Map segments ids.")] List<string> segmentIds,
        CancellationToken cancellation)
    {
        await client.Api.V2.Robot.Capabilities.MapSegmentationCapability.PutAsync(
            new MapSegmentationCapabilityPutRequestBody
            {
                Action = MapSegmentationCapabilityPutRequestBody_action.Start_segment_action,
                SegmentIds = segmentIds,
                Iterations = 1
            }, cancellationToken: cancellation);
        return "Operation executed successfully";
    }

    [McpServerTool(Name = "clean-all")]
    [Description(
        "Enforce vacuum robot to clean the hole map (flat, appartments or house) or resume current cleaning.")]
    public static async Task<string> CleanAll(ValetudoClient client, CancellationToken cancellation)
    {
        await client.Api.V2.Robot.Capabilities.BasicControlCapability.PutAsync(new BasicControlCapabilityPutRequestBody
        {
            Action = BasicControlCapabilityPutRequestBody_action.Start
        }, cancellationToken: cancellation);
        return "Operation executed successfully";
    }

    [McpServerTool(Name = "stop-cleaning")]
    [Description(
        "Enforce vacuum robot to stop cleaning.")]
    public static async Task<string> StopCleaning(ValetudoClient client, CancellationToken cancellation)
    {
        await client.Api.V2.Robot.Capabilities.BasicControlCapability.PutAsync(new BasicControlCapabilityPutRequestBody
        {
            Action = BasicControlCapabilityPutRequestBody_action.Stop
        }, cancellationToken: cancellation);
        return "Operation executed successfully";
    }

    [McpServerTool(Name = "pause-cleaning")]
    [Description(
        "Enforce vacuum robot to pause cleaning.")]
    public static async Task<string> PauseCleaning(ValetudoClient client, CancellationToken cancellation)
    {
        var x = await client.Api.V2.Robot.Capabilities.BasicControlCapability.PutAsync(
            new BasicControlCapabilityPutRequestBody
            {
                Action = BasicControlCapabilityPutRequestBody_action.Pause
            }, cancellationToken: cancellation);
        return "Operation executed successfully";
    }

    [McpServerTool(Name = "go-home")]
    [Description(
        "Enforce vacuum robot to go to charge station. Tip: if you get error try to stop cleaning using stop-cleaning tool first.")]
    public static async Task<string> GoHome(ValetudoClient client, CancellationToken cancellation)
    {
        await client.Api.V2.Robot.Capabilities.BasicControlCapability.PutAsync(new BasicControlCapabilityPutRequestBody
        {
            Action = BasicControlCapabilityPutRequestBody_action.Home
        }, cancellationToken: cancellation);
        return "Operation executed successfully";
    }
}
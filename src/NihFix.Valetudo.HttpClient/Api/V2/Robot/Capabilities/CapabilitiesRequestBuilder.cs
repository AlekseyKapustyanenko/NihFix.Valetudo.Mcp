// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.BasicControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CarpetModeControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CombinedVirtualRestrictionsCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ConsumableMonitoringCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CurrentStatisticsCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.DoNotDisturbCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.FanSpeedControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.LocateCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ManualControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapResetCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentEditCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentRenameCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentationCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.OperationModeControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.PersistentMapControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.QuirksCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerTestCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerVolumeControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.VoicePackManagementCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WaterUsageControlCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiConfigurationCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiScanCapability;
using NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ZoneCleaningCapability;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\robot\capabilities
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CapabilitiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The BasicControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.BasicControlCapability.BasicControlCapabilityRequestBuilder BasicControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.BasicControlCapability.BasicControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CarpetModeControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CarpetModeControlCapability.CarpetModeControlCapabilityRequestBuilder CarpetModeControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CarpetModeControlCapability.CarpetModeControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CombinedVirtualRestrictionsCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CombinedVirtualRestrictionsCapability.CombinedVirtualRestrictionsCapabilityRequestBuilder CombinedVirtualRestrictionsCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CombinedVirtualRestrictionsCapability.CombinedVirtualRestrictionsCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ConsumableMonitoringCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ConsumableMonitoringCapability.ConsumableMonitoringCapabilityRequestBuilder ConsumableMonitoringCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ConsumableMonitoringCapability.ConsumableMonitoringCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CurrentStatisticsCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CurrentStatisticsCapability.CurrentStatisticsCapabilityRequestBuilder CurrentStatisticsCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CurrentStatisticsCapability.CurrentStatisticsCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DoNotDisturbCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.DoNotDisturbCapability.DoNotDisturbCapabilityRequestBuilder DoNotDisturbCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.DoNotDisturbCapability.DoNotDisturbCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The FanSpeedControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.FanSpeedControlCapability.FanSpeedControlCapabilityRequestBuilder FanSpeedControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.FanSpeedControlCapability.FanSpeedControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The LocateCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.LocateCapability.LocateCapabilityRequestBuilder LocateCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.LocateCapability.LocateCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ManualControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ManualControlCapability.ManualControlCapabilityRequestBuilder ManualControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ManualControlCapability.ManualControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MapResetCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapResetCapability.MapResetCapabilityRequestBuilder MapResetCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapResetCapability.MapResetCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MapSegmentationCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentationCapability.MapSegmentationCapabilityRequestBuilder MapSegmentationCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentationCapability.MapSegmentationCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MapSegmentEditCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentEditCapability.MapSegmentEditCapabilityRequestBuilder MapSegmentEditCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentEditCapability.MapSegmentEditCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MapSegmentRenameCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentRenameCapability.MapSegmentRenameCapabilityRequestBuilder MapSegmentRenameCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.MapSegmentRenameCapability.MapSegmentRenameCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The OperationModeControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.OperationModeControlCapability.OperationModeControlCapabilityRequestBuilder OperationModeControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.OperationModeControlCapability.OperationModeControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The PersistentMapControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.PersistentMapControlCapability.PersistentMapControlCapabilityRequestBuilder PersistentMapControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.PersistentMapControlCapability.PersistentMapControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The QuirksCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.QuirksCapability.QuirksCapabilityRequestBuilder QuirksCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.QuirksCapability.QuirksCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SpeakerTestCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerTestCapability.SpeakerTestCapabilityRequestBuilder SpeakerTestCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerTestCapability.SpeakerTestCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SpeakerVolumeControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerVolumeControlCapability.SpeakerVolumeControlCapabilityRequestBuilder SpeakerVolumeControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.SpeakerVolumeControlCapability.SpeakerVolumeControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The VoicePackManagementCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.VoicePackManagementCapability.VoicePackManagementCapabilityRequestBuilder VoicePackManagementCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.VoicePackManagementCapability.VoicePackManagementCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WaterUsageControlCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WaterUsageControlCapability.WaterUsageControlCapabilityRequestBuilder WaterUsageControlCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WaterUsageControlCapability.WaterUsageControlCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WifiConfigurationCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiConfigurationCapability.WifiConfigurationCapabilityRequestBuilder WifiConfigurationCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiConfigurationCapability.WifiConfigurationCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WifiScanCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiScanCapability.WifiScanCapabilityRequestBuilder WifiScanCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.WifiScanCapability.WifiScanCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ZoneCleaningCapability property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ZoneCleaningCapability.ZoneCleaningCapabilityRequestBuilder ZoneCleaningCapability
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.ZoneCleaningCapability.ZoneCleaningCapabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CapabilitiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/robot/capabilities", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CapabilitiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/robot/capabilities", rawUrl)
        {
        }
        /// <summary>
        /// Get robot supported capabilities
        /// </summary>
        /// <returns>A List&lt;string&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<string>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<string>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<string>(requestInfo, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Get robot supported capabilities
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CapabilitiesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CapabilitiesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NihFix.Valetudo.HttpClient.Api.V2.Robot.Capabilities.CapabilitiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CapabilitiesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace;
using NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config;
using NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Log;
using NihFix.Valetudo.HttpClient.Api.V2.Valetudo.VersionNamespace;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NihFix.Valetudo.HttpClient.Api.V2.Valetudo
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\valetudo
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ValetudoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The action property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionRequestBuilder Action
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The config property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.ConfigRequestBuilder Config
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The log property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Log.LogRequestBuilder Log
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Log.LogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The version property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.VersionNamespace.VersionRequestBuilder Version
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.VersionNamespace.VersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValetudoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/valetudo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValetudoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/valetudo", rawUrl)
        {
        }
        /// <summary>
        /// Get basic Valetudo info
        /// </summary>
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoGetResponse?> GetAsValetudoGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoGetResponse> GetAsValetudoGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoGetResponse>(requestInfo, global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get basic Valetudo info
        /// </summary>
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsValetudoGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoResponse>(requestInfo, global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get basic Valetudo info
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
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ValetudoRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ValetudoRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

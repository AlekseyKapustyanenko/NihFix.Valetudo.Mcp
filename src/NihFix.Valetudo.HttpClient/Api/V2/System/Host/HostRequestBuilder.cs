// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using NihFix.Valetudo.HttpClient.Api.V2.System.Host.Info;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace NihFix.Valetudo.HttpClient.Api.V2.System.Host
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\system\host
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HostRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The info property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.System.Host.Info.InfoRequestBuilder Info
        {
            get => new global::NihFix.Valetudo.HttpClient.Api.V2.System.Host.Info.InfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.System.Host.HostRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HostRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/system/host", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.System.Host.HostRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HostRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/system/host", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.X.OpenApiClient.Two.Likes.Firehose.StreamNamespace;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.X.OpenApiClient.Two.Likes.Firehose
{
    /// <summary>
    /// Builds and executes requests for operations under \2\likes\firehose
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FirehoseRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The stream property</summary>
        public global::Soenneker.X.OpenApiClient.Two.Likes.Firehose.StreamNamespace.StreamRequestBuilder Stream
        {
            get => new global::Soenneker.X.OpenApiClient.Two.Likes.Firehose.StreamNamespace.StreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Likes.Firehose.FirehoseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FirehoseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/likes/firehose", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Likes.Firehose.FirehoseRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FirehoseRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/likes/firehose", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

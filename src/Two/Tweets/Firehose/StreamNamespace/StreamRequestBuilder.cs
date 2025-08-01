// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.X.OpenApiClient.Models;
using Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.Lang;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace
{
    /// <summary>
    /// Builds and executes requests for operations under \2\tweets\firehose\stream
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StreamRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The lang property</summary>
        public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.Lang.LangRequestBuilder Lang
        {
            get => new global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.Lang.LangRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StreamRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/firehose/stream?partition={partition}{&backfill_minutes*,end_time*,expansions,media%2Efields,place%2Efields,poll%2Efields,start_time*,tweet%2Efields,user%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StreamRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/firehose/stream?partition={partition}{&backfill_minutes*,end_time*,expansions,media%2Efields,place%2Efields,poll%2Efields,start_time*,tweet%2Efields,user%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Streams all public Posts in real-time.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.StreamingTweetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.StreamingTweetResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder.StreamRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.StreamingTweetResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder.StreamRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.StreamingTweetResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.StreamingTweetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Streams all public Posts in real-time.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder.StreamRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder.StreamRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Streams all public Posts in real-time.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StreamRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of minutes of backfill requested.</summary>
            [QueryParameter("backfill_minutes")]
            public int? BackfillMinutes { get; set; }
            /// <summary>YYYY-MM-DDTHH:mm:ssZ. The latest UTC timestamp to which the Posts will be provided.</summary>
            [QueryParameter("end_time")]
            public DateTimeOffset? EndTime { get; set; }
            /// <summary>A comma separated list of fields to expand.</summary>
            [Obsolete("This property is deprecated, use ExpansionsAsGetExpansionsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expansions")]
            public string[]? Expansions { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public string[] Expansions { get; set; }
#endif
            /// <summary>A comma separated list of fields to expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetExpansionsQueryParameterType[]? ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetExpansionsQueryParameterType[] ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#endif
            /// <summary>A comma separated list of Media fields to display.</summary>
            [Obsolete("This property is deprecated, use MediaFieldsAsGetMediaFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("media%2Efields")]
            public string[]? MediaFields { get; set; }
#nullable restore
#else
            [QueryParameter("media%2Efields")]
            public string[] MediaFields { get; set; }
#endif
            /// <summary>A comma separated list of Media fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("media%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetMediaFieldsQueryParameterType[]? MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("media%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetMediaFieldsQueryParameterType[] MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
#endif
            /// <summary>The partition number.</summary>
            [QueryParameter("partition")]
            public int? Partition { get; set; }
            /// <summary>A comma separated list of Place fields to display.</summary>
            [Obsolete("This property is deprecated, use PlaceFieldsAsGetPlaceFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("place%2Efields")]
            public string[]? PlaceFields { get; set; }
#nullable restore
#else
            [QueryParameter("place%2Efields")]
            public string[] PlaceFields { get; set; }
#endif
            /// <summary>A comma separated list of Place fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("place%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetPlaceFieldsQueryParameterType[]? PlaceFieldsAsGetPlaceFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("place%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetPlaceFieldsQueryParameterType[] PlaceFieldsAsGetPlaceFieldsQueryParameterType { get; set; }
#endif
            /// <summary>A comma separated list of Poll fields to display.</summary>
            [Obsolete("This property is deprecated, use PollFieldsAsGetPollFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("poll%2Efields")]
            public string[]? PollFields { get; set; }
#nullable restore
#else
            [QueryParameter("poll%2Efields")]
            public string[] PollFields { get; set; }
#endif
            /// <summary>A comma separated list of Poll fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("poll%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetPollFieldsQueryParameterType[]? PollFieldsAsGetPollFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("poll%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetPollFieldsQueryParameterType[] PollFieldsAsGetPollFieldsQueryParameterType { get; set; }
#endif
            /// <summary>YYYY-MM-DDTHH:mm:ssZ. The earliest UTC timestamp to which the Posts will be provided.</summary>
            [QueryParameter("start_time")]
            public DateTimeOffset? StartTime { get; set; }
            /// <summary>A comma separated list of Tweet fields to display.</summary>
            [Obsolete("This property is deprecated, use TweetFieldsAsGetTweetFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tweet%2Efields")]
            public string[]? TweetFields { get; set; }
#nullable restore
#else
            [QueryParameter("tweet%2Efields")]
            public string[] TweetFields { get; set; }
#endif
            /// <summary>A comma separated list of Tweet fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tweet%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetTweetFieldsQueryParameterType[]? TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("tweet%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetTweetFieldsQueryParameterType[] TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
#endif
            /// <summary>A comma separated list of User fields to display.</summary>
            [Obsolete("This property is deprecated, use UserFieldsAsGetUserFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user%2Efields")]
            public string[]? UserFields { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public string[] UserFields { get; set; }
#endif
            /// <summary>A comma separated list of User fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetUserFieldsQueryParameterType[]? UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.GetUserFieldsQueryParameterType[] UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class StreamRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Firehose.StreamNamespace.StreamRequestBuilder.StreamRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

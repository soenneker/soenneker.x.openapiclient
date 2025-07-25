// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.X.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts
{
    /// <summary>
    /// Builds and executes requests for operations under \2\tweets\search\stream\rules\counts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/search/stream/rules/counts{?rules_count%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/search/stream/rules/counts{?rules_count%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves the count of rules in the active rule set for the filtered stream.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Get2TweetsSearchStreamRulesCountsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2TweetsSearchStreamRulesCountsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder.CountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2TweetsSearchStreamRulesCountsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder.CountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.Get2TweetsSearchStreamRulesCountsResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.Get2TweetsSearchStreamRulesCountsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the count of rules in the active rule set for the filtered stream.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder.CountsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder.CountsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves the count of rules in the active rule set for the filtered stream.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CountsRequestBuilderGetQueryParameters 
        {
            /// <summary>A comma separated list of RulesCount fields to display.</summary>
            [Obsolete("This property is deprecated, use RulesCountFieldsAsGetRulesCountFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("rules_count%2Efields")]
            public string[]? RulesCountFields { get; set; }
#nullable restore
#else
            [QueryParameter("rules_count%2Efields")]
            public string[] RulesCountFields { get; set; }
#endif
            /// <summary>A comma separated list of RulesCount fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("rules_count%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.GetRules_countFieldsQueryParameterType[]? RulesCountFieldsAsGetRulesCountFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("rules_count%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.GetRules_countFieldsQueryParameterType[] RulesCountFieldsAsGetRulesCountFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CountsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Search.StreamNamespace.Rules.Counts.CountsRequestBuilder.CountsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

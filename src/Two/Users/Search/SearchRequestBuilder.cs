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
namespace Soenneker.X.OpenApiClient.Two.Users.Search
{
    /// <summary>
    /// Builds and executes requests for operations under \2\users\search
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SearchRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/users/search?query={query}{&expansions,max_results*,next_token*,tweet%2Efields,user%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/users/search?query={query}{&expansions,max_results*,next_token*,tweet%2Efields,user%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves a list of Users matching a search query.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Get2UsersSearchResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2UsersSearchResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder.SearchRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2UsersSearchResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder.SearchRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.Get2UsersSearchResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.Get2UsersSearchResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a list of Users matching a search query.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder.SearchRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder.SearchRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves a list of Users matching a search query.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SearchRequestBuilderGetQueryParameters 
        {
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
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetExpansionsQueryParameterType[]? ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetExpansionsQueryParameterType[] ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#endif
            /// <summary>The maximum number of results.</summary>
            [QueryParameter("max_results")]
            public int? MaxResults { get; set; }
            /// <summary>This parameter is used to get the next &apos;page&apos; of results. The value used with the parameter is pulled directly from the response provided by the API, and should not be modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("next_token")]
            public string? NextToken { get; set; }
#nullable restore
#else
            [QueryParameter("next_token")]
            public string NextToken { get; set; }
#endif
            /// <summary>TThe the query string by which to query for users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
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
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetTweetFieldsQueryParameterType[]? TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("tweet%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetTweetFieldsQueryParameterType[] TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetUserFieldsQueryParameterType[]? UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Users.Search.GetUserFieldsQueryParameterType[] UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SearchRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Users.Search.SearchRequestBuilder.SearchRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

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
namespace Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets
{
    /// <summary>
    /// Builds and executes requests for operations under \2\tweets\{-id}\quote_tweets
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Quote_tweetsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Quote_tweetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/{%2Did}/quote_tweets{?exclude,expansions,max_results*,media%2Efields,pagination_token*,place%2Efields,poll%2Efields,tweet%2Efields,user%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Quote_tweetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/tweets/{%2Did}/quote_tweets{?exclude,expansions,max_results*,media%2Efields,pagination_token*,place%2Efields,poll%2Efields,tweet%2Efields,user%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves a list of Posts that quote a specific Post by its ID.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Get2TweetsIdQuoteTweetsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2TweetsIdQuoteTweetsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder.Quote_tweetsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2TweetsIdQuoteTweetsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder.Quote_tweetsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.Get2TweetsIdQuoteTweetsResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.Get2TweetsIdQuoteTweetsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a list of Posts that quote a specific Post by its ID.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder.Quote_tweetsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder.Quote_tweetsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves a list of Posts that quote a specific Post by its ID.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Quote_tweetsRequestBuilderGetQueryParameters 
        {
            /// <summary>The set of entities to exclude (e.g. &apos;replies&apos; or &apos;retweets&apos;).</summary>
            [Obsolete("This property is deprecated, use ExcludeAsGetExcludeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("exclude")]
            public string[]? Exclude { get; set; }
#nullable restore
#else
            [QueryParameter("exclude")]
            public string[] Exclude { get; set; }
#endif
            /// <summary>The set of entities to exclude (e.g. &apos;replies&apos; or &apos;retweets&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("exclude")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetExcludeQueryParameterType[]? ExcludeAsGetExcludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("exclude")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetExcludeQueryParameterType[] ExcludeAsGetExcludeQueryParameterType { get; set; }
#endif
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetExpansionsQueryParameterType[]? ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetExpansionsQueryParameterType[] ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#endif
            /// <summary>The maximum number of results to be returned.</summary>
            [QueryParameter("max_results")]
            public int? MaxResults { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetMediaFieldsQueryParameterType[]? MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("media%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetMediaFieldsQueryParameterType[] MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
#endif
            /// <summary>This parameter is used to get a specified &apos;page&apos; of results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("pagination_token")]
            public string? PaginationToken { get; set; }
#nullable restore
#else
            [QueryParameter("pagination_token")]
            public string PaginationToken { get; set; }
#endif
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetPlaceFieldsQueryParameterType[]? PlaceFieldsAsGetPlaceFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("place%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetPlaceFieldsQueryParameterType[] PlaceFieldsAsGetPlaceFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetPollFieldsQueryParameterType[]? PollFieldsAsGetPollFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("poll%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetPollFieldsQueryParameterType[] PollFieldsAsGetPollFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetTweetFieldsQueryParameterType[]? TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("tweet%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetTweetFieldsQueryParameterType[] TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetUserFieldsQueryParameterType[]? UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.GetUserFieldsQueryParameterType[] UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Quote_tweetsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Tweets.Item.Quote_tweets.Quote_tweetsRequestBuilder.Quote_tweetsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

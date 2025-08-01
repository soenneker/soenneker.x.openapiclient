// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.X.OpenApiClient.Models;
using Soenneker.X.OpenApiClient.Two.Spaces.By;
using Soenneker.X.OpenApiClient.Two.Spaces.Item;
using Soenneker.X.OpenApiClient.Two.Spaces.Search;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.X.OpenApiClient.Two.Spaces
{
    /// <summary>
    /// Builds and executes requests for operations under \2\spaces
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SpacesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The by property</summary>
        public global::Soenneker.X.OpenApiClient.Two.Spaces.By.ByRequestBuilder By
        {
            get => new global::Soenneker.X.OpenApiClient.Two.Spaces.By.ByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public global::Soenneker.X.OpenApiClient.Two.Spaces.Search.SearchRequestBuilder Search
        {
            get => new global::Soenneker.X.OpenApiClient.Two.Spaces.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.X.OpenApiClient.Two.spaces.item collection</summary>
        /// <param name="position">The ID of the Space to be retrieved.</param>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Spaces.Item.SpacesItemRequestBuilder"/></returns>
        public global::Soenneker.X.OpenApiClient.Two.Spaces.Item.SpacesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.X.OpenApiClient.Two.Spaces.Item.SpacesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpacesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/spaces?ids={ids}{&expansions,space%2Efields,topic%2Efields,user%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SpacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/spaces?ids={ids}{&expansions,space%2Efields,topic%2Efields,user%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves details of multiple Spaces by their IDs.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Get2SpacesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2SpacesResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder.SpacesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2SpacesResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder.SpacesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.Get2SpacesResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.Get2SpacesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves details of multiple Spaces by their IDs.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder.SpacesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder.SpacesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves details of multiple Spaces by their IDs.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SpacesRequestBuilderGetQueryParameters 
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
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetExpansionsQueryParameterType[]? ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetExpansionsQueryParameterType[] ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#endif
            /// <summary>The list of Space IDs to return.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public string[]? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public string[] Ids { get; set; }
#endif
            /// <summary>A comma separated list of Space fields to display.</summary>
            [Obsolete("This property is deprecated, use SpaceFieldsAsGetSpaceFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("space%2Efields")]
            public string[]? SpaceFields { get; set; }
#nullable restore
#else
            [QueryParameter("space%2Efields")]
            public string[] SpaceFields { get; set; }
#endif
            /// <summary>A comma separated list of Space fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("space%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetSpaceFieldsQueryParameterType[]? SpaceFieldsAsGetSpaceFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("space%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetSpaceFieldsQueryParameterType[] SpaceFieldsAsGetSpaceFieldsQueryParameterType { get; set; }
#endif
            /// <summary>A comma separated list of Topic fields to display.</summary>
            [Obsolete("This property is deprecated, use TopicFieldsAsGetTopicFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("topic%2Efields")]
            public string[]? TopicFields { get; set; }
#nullable restore
#else
            [QueryParameter("topic%2Efields")]
            public string[] TopicFields { get; set; }
#endif
            /// <summary>A comma separated list of Topic fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("topic%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetTopicFieldsQueryParameterType[]? TopicFieldsAsGetTopicFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("topic%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetTopicFieldsQueryParameterType[] TopicFieldsAsGetTopicFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetUserFieldsQueryParameterType[]? UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Spaces.GetUserFieldsQueryParameterType[] UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SpacesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Spaces.SpacesRequestBuilder.SpacesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

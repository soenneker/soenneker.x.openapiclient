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
namespace Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events
{
    /// <summary>
    /// Builds and executes requests for operations under \2\dm_conversations\with\{participant_id}\dm_events
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Dm_eventsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Dm_eventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/dm_conversations/with/{participant_id}/dm_events{?dm_event%2Efields,event_types,expansions,max_results*,media%2Efields,pagination_token*,tweet%2Efields,user%2Efields}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Dm_eventsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/2/dm_conversations/with/{participant_id}/dm_events{?dm_event%2Efields,event_types,expansions,max_results*,media%2Efields,pagination_token*,tweet%2Efields,user%2Efields}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves direct message events for a specific conversation.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Get2DmConversationsWithParticipantIdDmEventsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.X.OpenApiClient.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2DmConversationsWithParticipantIdDmEventsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder.Dm_eventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.X.OpenApiClient.Models.Get2DmConversationsWithParticipantIdDmEventsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder.Dm_eventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.X.OpenApiClient.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.X.OpenApiClient.Models.Get2DmConversationsWithParticipantIdDmEventsResponse>(requestInfo, global::Soenneker.X.OpenApiClient.Models.Get2DmConversationsWithParticipantIdDmEventsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves direct message events for a specific conversation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder.Dm_eventsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder.Dm_eventsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves direct message events for a specific conversation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Dm_eventsRequestBuilderGetQueryParameters 
        {
            /// <summary>A comma separated list of DmEvent fields to display.</summary>
            [Obsolete("This property is deprecated, use DmEventFieldsAsGetDmEventFieldsQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dm_event%2Efields")]
            public string[]? DmEventFields { get; set; }
#nullable restore
#else
            [QueryParameter("dm_event%2Efields")]
            public string[] DmEventFields { get; set; }
#endif
            /// <summary>A comma separated list of DmEvent fields to display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dm_event%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetDm_eventFieldsQueryParameterType[]? DmEventFieldsAsGetDmEventFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("dm_event%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetDm_eventFieldsQueryParameterType[] DmEventFieldsAsGetDmEventFieldsQueryParameterType { get; set; }
#endif
            /// <summary>The set of event_types to include in the results.</summary>
            [Obsolete("This property is deprecated, use EventTypesAsGetEventTypesQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("event_types")]
            public string[]? EventTypes { get; set; }
#nullable restore
#else
            [QueryParameter("event_types")]
            public string[] EventTypes { get; set; }
#endif
            /// <summary>The set of event_types to include in the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("event_types")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetEvent_typesQueryParameterType[]? EventTypesAsGetEventTypesQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("event_types")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetEvent_typesQueryParameterType[] EventTypesAsGetEventTypesQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetExpansionsQueryParameterType[]? ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("expansions")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetExpansionsQueryParameterType[] ExpansionsAsGetExpansionsQueryParameterType { get; set; }
#endif
            /// <summary>The maximum number of results.</summary>
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
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetMediaFieldsQueryParameterType[]? MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("media%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetMediaFieldsQueryParameterType[] MediaFieldsAsGetMediaFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetTweetFieldsQueryParameterType[]? TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("tweet%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetTweetFieldsQueryParameterType[] TweetFieldsAsGetTweetFieldsQueryParameterType { get; set; }
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
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetUserFieldsQueryParameterType[]? UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("user%2Efields")]
            public global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.GetUserFieldsQueryParameterType[] UserFieldsAsGetUserFieldsQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Dm_eventsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.X.OpenApiClient.Two.Dm_conversations.With.Item.Dm_events.Dm_eventsRequestBuilder.Dm_eventsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618

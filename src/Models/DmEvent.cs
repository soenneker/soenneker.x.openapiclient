// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.X.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DmEvent : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the type of attachments (if any) present in this DM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments? Attachments { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments Attachments { get; set; }
#endif
        /// <summary>The cashtags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.CashtagEntity>? Cashtags { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.CashtagEntity> Cashtags { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Unique identifier of a DM conversation. This can either be a numeric string, or a pair of numeric strings separated by a &apos;-&apos; character in the case of one-on-one DM Conversations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DmConversationId { get; set; }
#nullable restore
#else
        public string DmConversationId { get; set; }
#endif
        /// <summary>The event_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventType { get; set; }
#nullable restore
#else
        public string EventType { get; set; }
#endif
        /// <summary>The hashtags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.HashtagEntity>? Hashtags { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.HashtagEntity> Hashtags { get; set; }
#endif
        /// <summary>Unique identifier of a DM Event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The mentions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.MentionEntity>? Mentions { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.MentionEntity> Mentions { get; set; }
#endif
        /// <summary>A list of participants for a ParticipantsJoin or ParticipantsLeave event_type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ParticipantIds { get; set; }
#nullable restore
#else
        public List<string> ParticipantIds { get; set; }
#endif
        /// <summary>A list of Posts this DM refers to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.DmEvent_referenced_tweets>? ReferencedTweets { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.DmEvent_referenced_tweets> ReferencedTweets { get; set; }
#endif
        /// <summary>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderId { get; set; }
#nullable restore
#else
        public string SenderId { get; set; }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The urls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.UrlEntityDm>? Urls { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.UrlEntityDm> Urls { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.DmEvent"/> and sets the default values.
        /// </summary>
        public DmEvent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.DmEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.DmEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.DmEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attachments", n => { Attachments = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments>(global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments.CreateFromDiscriminatorValue); } },
                { "cashtags", n => { Cashtags = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.CashtagEntity>(global::Soenneker.X.OpenApiClient.Models.CashtagEntity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "dm_conversation_id", n => { DmConversationId = n.GetStringValue(); } },
                { "event_type", n => { EventType = n.GetStringValue(); } },
                { "hashtags", n => { Hashtags = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.HashtagEntity>(global::Soenneker.X.OpenApiClient.Models.HashtagEntity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "mentions", n => { Mentions = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.MentionEntity>(global::Soenneker.X.OpenApiClient.Models.MentionEntity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "participant_ids", n => { ParticipantIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "referenced_tweets", n => { ReferencedTweets = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.DmEvent_referenced_tweets>(global::Soenneker.X.OpenApiClient.Models.DmEvent_referenced_tweets.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sender_id", n => { SenderId = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "urls", n => { Urls = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.UrlEntityDm>(global::Soenneker.X.OpenApiClient.Models.UrlEntityDm.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.CashtagEntity>("cashtags", Cashtags);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("dm_conversation_id", DmConversationId);
            writer.WriteStringValue("event_type", EventType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.HashtagEntity>("hashtags", Hashtags);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.MentionEntity>("mentions", Mentions);
            writer.WriteCollectionOfPrimitiveValues<string>("participant_ids", ParticipantIds);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.DmEvent_referenced_tweets>("referenced_tweets", ReferencedTweets);
            writer.WriteStringValue("sender_id", SenderId);
            writer.WriteStringValue("text", Text);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.UrlEntityDm>("urls", Urls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

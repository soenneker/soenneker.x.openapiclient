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
    public partial class Tweet : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the type of attachments (if any) present in this Tweet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_attachments? Attachments { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_attachments Attachments { get; set; }
#endif
        /// <summary>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthorId { get; set; }
#nullable restore
#else
        public string AuthorId { get; set; }
#endif
        /// <summary>The unique identifier of this Community.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommunityId { get; set; }
#nullable restore
#else
        public string CommunityId { get; set; }
#endif
        /// <summary>The context_annotations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.ContextAnnotation>? ContextAnnotations { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.ContextAnnotation> ContextAnnotations { get; set; }
#endif
        /// <summary>Unique identifier of this Tweet. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationId { get; set; }
#nullable restore
#else
        public string ConversationId { get; set; }
#endif
        /// <summary>Creation time of the Tweet.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Represent a boundary range (start and end zero-based indices) for the portion of text that is displayed for a post. `start` must be smaller than `end`. The start index is inclusive, the end index is exclusive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? DisplayTextRange { get; set; }
#nullable restore
#else
        public List<int?> DisplayTextRange { get; set; }
#endif
        /// <summary>The edit_controls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_edit_controls? EditControls { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_edit_controls EditControls { get; set; }
#endif
        /// <summary>A list of Tweet Ids in this Tweet chain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EditHistoryTweetIds { get; set; }
#nullable restore
#else
        public List<string> EditHistoryTweetIds { get; set; }
#endif
        /// <summary>The entities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.FullTextEntities? Entities { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.FullTextEntities Entities { get; set; }
#endif
        /// <summary>The location tagged on the Tweet, if the user provided one.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_geo? Geo { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_geo Geo { get; set; }
#endif
        /// <summary>Unique identifier of this Tweet. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Unique identifier of this User. This is returned as a string in order to avoid complications with languages and tools that cannot handle large integers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InReplyToUserId { get; set; }
#nullable restore
#else
        public string InReplyToUserId { get; set; }
#endif
        /// <summary>Language of the Tweet, if detected by X. Returned as a BCP47 language tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Lang { get; set; }
#nullable restore
#else
        public string Lang { get; set; }
#endif
        /// <summary>Nonpublic engagement metrics for the Tweet at the time of the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_non_public_metrics? NonPublicMetrics { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_non_public_metrics NonPublicMetrics { get; set; }
#endif
        /// <summary>The full-content of the Tweet, including text beyond 280 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_note_tweet? NoteTweet { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_note_tweet NoteTweet { get; set; }
#endif
        /// <summary>Organic nonpublic engagement metrics for the Tweet at the time of the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_organic_metrics? OrganicMetrics { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_organic_metrics OrganicMetrics { get; set; }
#endif
        /// <summary>Indicates if this Tweet contains URLs marked as sensitive, for example content suitable for mature audiences.</summary>
        public bool? PossiblySensitive { get; set; }
        /// <summary>Promoted nonpublic engagement metrics for the Tweet at the time of the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_promoted_metrics? PromotedMetrics { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_promoted_metrics PromotedMetrics { get; set; }
#endif
        /// <summary>Engagement metrics for the Tweet at the time of the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_public_metrics? PublicMetrics { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_public_metrics PublicMetrics { get; set; }
#endif
        /// <summary>A list of Posts this Tweet refers to. For example, if the parent Tweet is a Retweet, a Quoted Tweet or a Reply, it will include the related Tweet referenced to by its parent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.Tweet_referenced_tweets>? ReferencedTweets { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.Tweet_referenced_tweets> ReferencedTweets { get; set; }
#endif
        /// <summary>Shows who can reply a Tweet. Fields returned are everyone, mentioned_users, subscribers, verified and following.</summary>
        public global::Soenneker.X.OpenApiClient.Models.ReplySettingsWithVerifiedUsers? ReplySettings { get; set; }
        /// <summary>The scopes for this tweet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Tweet_scopes? Scopes { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Tweet_scopes Scopes { get; set; }
#endif
        /// <summary>This is deprecated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The content of the Tweet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The X handle (screen name) of this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>Indicates withholding details for [withheld content](https://help.twitter.com/en/rules-and-policies/tweet-withheld-by-country).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.TweetWithheld? Withheld { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.TweetWithheld Withheld { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.Tweet"/> and sets the default values.
        /// </summary>
        public Tweet()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Tweet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.Tweet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.Tweet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attachments", n => { Attachments = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_attachments>(global::Soenneker.X.OpenApiClient.Models.Tweet_attachments.CreateFromDiscriminatorValue); } },
                { "author_id", n => { AuthorId = n.GetStringValue(); } },
                { "community_id", n => { CommunityId = n.GetStringValue(); } },
                { "context_annotations", n => { ContextAnnotations = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.ContextAnnotation>(global::Soenneker.X.OpenApiClient.Models.ContextAnnotation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "conversation_id", n => { ConversationId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "display_text_range", n => { DisplayTextRange = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "edit_controls", n => { EditControls = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_edit_controls>(global::Soenneker.X.OpenApiClient.Models.Tweet_edit_controls.CreateFromDiscriminatorValue); } },
                { "edit_history_tweet_ids", n => { EditHistoryTweetIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "entities", n => { Entities = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.FullTextEntities>(global::Soenneker.X.OpenApiClient.Models.FullTextEntities.CreateFromDiscriminatorValue); } },
                { "geo", n => { Geo = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_geo>(global::Soenneker.X.OpenApiClient.Models.Tweet_geo.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "in_reply_to_user_id", n => { InReplyToUserId = n.GetStringValue(); } },
                { "lang", n => { Lang = n.GetStringValue(); } },
                { "non_public_metrics", n => { NonPublicMetrics = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_non_public_metrics>(global::Soenneker.X.OpenApiClient.Models.Tweet_non_public_metrics.CreateFromDiscriminatorValue); } },
                { "note_tweet", n => { NoteTweet = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_note_tweet>(global::Soenneker.X.OpenApiClient.Models.Tweet_note_tweet.CreateFromDiscriminatorValue); } },
                { "organic_metrics", n => { OrganicMetrics = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_organic_metrics>(global::Soenneker.X.OpenApiClient.Models.Tweet_organic_metrics.CreateFromDiscriminatorValue); } },
                { "possibly_sensitive", n => { PossiblySensitive = n.GetBoolValue(); } },
                { "promoted_metrics", n => { PromotedMetrics = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_promoted_metrics>(global::Soenneker.X.OpenApiClient.Models.Tweet_promoted_metrics.CreateFromDiscriminatorValue); } },
                { "public_metrics", n => { PublicMetrics = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_public_metrics>(global::Soenneker.X.OpenApiClient.Models.Tweet_public_metrics.CreateFromDiscriminatorValue); } },
                { "referenced_tweets", n => { ReferencedTweets = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.Tweet_referenced_tweets>(global::Soenneker.X.OpenApiClient.Models.Tweet_referenced_tweets.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reply_settings", n => { ReplySettings = n.GetEnumValue<global::Soenneker.X.OpenApiClient.Models.ReplySettingsWithVerifiedUsers>(); } },
                { "scopes", n => { Scopes = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_scopes>(global::Soenneker.X.OpenApiClient.Models.Tweet_scopes.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "username", n => { Username = n.GetStringValue(); } },
                { "withheld", n => { Withheld = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.TweetWithheld>(global::Soenneker.X.OpenApiClient.Models.TweetWithheld.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_attachments>("attachments", Attachments);
            writer.WriteStringValue("author_id", AuthorId);
            writer.WriteStringValue("community_id", CommunityId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.ContextAnnotation>("context_annotations", ContextAnnotations);
            writer.WriteStringValue("conversation_id", ConversationId);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteCollectionOfPrimitiveValues<int?>("display_text_range", DisplayTextRange);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_edit_controls>("edit_controls", EditControls);
            writer.WriteCollectionOfPrimitiveValues<string>("edit_history_tweet_ids", EditHistoryTweetIds);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.FullTextEntities>("entities", Entities);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_geo>("geo", Geo);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("in_reply_to_user_id", InReplyToUserId);
            writer.WriteStringValue("lang", Lang);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_non_public_metrics>("non_public_metrics", NonPublicMetrics);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_note_tweet>("note_tweet", NoteTweet);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_organic_metrics>("organic_metrics", OrganicMetrics);
            writer.WriteBoolValue("possibly_sensitive", PossiblySensitive);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_promoted_metrics>("promoted_metrics", PromotedMetrics);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_public_metrics>("public_metrics", PublicMetrics);
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.Tweet_referenced_tweets>("referenced_tweets", ReferencedTweets);
            writer.WriteEnumValue<global::Soenneker.X.OpenApiClient.Models.ReplySettingsWithVerifiedUsers>("reply_settings", ReplySettings);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Tweet_scopes>("scopes", Scopes);
            writer.WriteStringValue("source", Source);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("username", Username);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.TweetWithheld>("withheld", Withheld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

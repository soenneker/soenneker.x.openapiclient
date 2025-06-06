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
    public partial class UserProfileModificationObjectSchema : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Event time.</summary>
        public DateTimeOffset? EventAt { get; set; }
        /// <summary>The new_value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewValue { get; set; }
#nullable restore
#else
        public string NewValue { get; set; }
#endif
        /// <summary>The profile_field property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileField { get; set; }
#nullable restore
#else
        public string ProfileField { get; set; }
#endif
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema_user? User { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema_user User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema"/> and sets the default values.
        /// </summary>
        public UserProfileModificationObjectSchema()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "event_at", n => { EventAt = n.GetDateTimeOffsetValue(); } },
                { "new_value", n => { NewValue = n.GetStringValue(); } },
                { "profile_field", n => { ProfileField = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema_user>(global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema_user.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("event_at", EventAt);
            writer.WriteStringValue("new_value", NewValue);
            writer.WriteStringValue("profile_field", ProfileField);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.UserProfileModificationObjectSchema_user>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

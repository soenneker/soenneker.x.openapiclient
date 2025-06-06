// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.X.OpenApiClient.Models
{
    /// <summary>
    /// Specifies the type of attachments (if any) present in this DM.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DmEvent_attachments : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of card IDs (if cards are attached).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CardIds { get; set; }
#nullable restore
#else
        public List<string> CardIds { get; set; }
#endif
        /// <summary>A list of Media Keys for each one of the media attachments (if media are attached).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaKeys { get; set; }
#nullable restore
#else
        public List<string> MediaKeys { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments"/> and sets the default values.
        /// </summary>
        public DmEvent_attachments()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.DmEvent_attachments();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card_ids", n => { CardIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "media_keys", n => { MediaKeys = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("card_ids", CardIds);
            writer.WriteCollectionOfPrimitiveValues<string>("media_keys", MediaKeys);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

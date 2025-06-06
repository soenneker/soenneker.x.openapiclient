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
    public partial class SubtitlesCreateRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of this Media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The media category of uploaded media to which subtitles should be added/deleted</summary>
        public global::Soenneker.X.OpenApiClient.Models.MediaCategorySubtitles? MediaCategory { get; set; }
        /// <summary>The subtitles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.Subtitles? Subtitles { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.Subtitles Subtitles { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.SubtitlesCreateRequest"/> and sets the default values.
        /// </summary>
        public SubtitlesCreateRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.SubtitlesCreateRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.SubtitlesCreateRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.SubtitlesCreateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetStringValue(); } },
                { "media_category", n => { MediaCategory = n.GetEnumValue<global::Soenneker.X.OpenApiClient.Models.MediaCategorySubtitles>(); } },
                { "subtitles", n => { Subtitles = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.Subtitles>(global::Soenneker.X.OpenApiClient.Models.Subtitles.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Soenneker.X.OpenApiClient.Models.MediaCategorySubtitles>("media_category", MediaCategory);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.Subtitles>("subtitles", Subtitles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

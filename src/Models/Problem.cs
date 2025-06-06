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
    /// An HTTP Problem Details object, as defined in IETF RFC 7807 (https://tools.ietf.org/html/rfc7807).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Problem : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The detail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Detail { get; set; }
#nullable restore
#else
        public string Detail { get; set; }
#endif
        /// <summary>The status property</summary>
        public int? Status { get; set; }
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.Problem"/> and sets the default values.
        /// </summary>
        public Problem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.Problem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.Problem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            return mappingValue switch
            {
                "about:blank" => new global::Soenneker.X.OpenApiClient.Models.GenericProblem(),
                "https://api.twitter.com/2/problems/client-disconnected" => new global::Soenneker.X.OpenApiClient.Models.ClientDisconnectedProblem(),
                "https://api.twitter.com/2/problems/client-forbidden" => new global::Soenneker.X.OpenApiClient.Models.ClientForbiddenProblem(),
                "https://api.twitter.com/2/problems/conflict" => new global::Soenneker.X.OpenApiClient.Models.ConflictProblem(),
                "https://api.twitter.com/2/problems/disallowed-resource" => new global::Soenneker.X.OpenApiClient.Models.DisallowedResourceProblem(),
                "https://api.twitter.com/2/problems/duplicate-rules" => new global::Soenneker.X.OpenApiClient.Models.DuplicateRuleProblem(),
                "https://api.twitter.com/2/problems/invalid-request" => new global::Soenneker.X.OpenApiClient.Models.InvalidRequestProblem(),
                "https://api.twitter.com/2/problems/invalid-rules" => new global::Soenneker.X.OpenApiClient.Models.InvalidRuleProblem(),
                "https://api.twitter.com/2/problems/noncompliant-rules" => new global::Soenneker.X.OpenApiClient.Models.NonCompliantRulesProblem(),
                "https://api.twitter.com/2/problems/not-authorized-for-field" => new global::Soenneker.X.OpenApiClient.Models.FieldUnauthorizedProblem(),
                "https://api.twitter.com/2/problems/not-authorized-for-resource" => new global::Soenneker.X.OpenApiClient.Models.ResourceUnauthorizedProblem(),
                "https://api.twitter.com/2/problems/operational-disconnect" => new global::Soenneker.X.OpenApiClient.Models.OperationalDisconnectProblem(),
                "https://api.twitter.com/2/problems/resource-not-found" => new global::Soenneker.X.OpenApiClient.Models.ResourceNotFoundProblem(),
                "https://api.twitter.com/2/problems/resource-unavailable" => new global::Soenneker.X.OpenApiClient.Models.ResourceUnavailableProblem(),
                "https://api.twitter.com/2/problems/rule-cap" => new global::Soenneker.X.OpenApiClient.Models.RulesCapProblem(),
                "https://api.twitter.com/2/problems/streaming-connection" => new global::Soenneker.X.OpenApiClient.Models.ConnectionExceptionProblem(),
                "https://api.twitter.com/2/problems/unsupported-authentication" => new global::Soenneker.X.OpenApiClient.Models.UnsupportedAuthenticationProblem(),
                "https://api.twitter.com/2/problems/usage-capped" => new global::Soenneker.X.OpenApiClient.Models.UsageCapExceededProblem(),
                _ => new global::Soenneker.X.OpenApiClient.Models.Problem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detail", n => { Detail = n.GetStringValue(); } },
                { "status", n => { Status = n.GetIntValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteIntValue("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

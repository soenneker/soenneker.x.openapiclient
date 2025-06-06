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
    /// A count of user-provided stream filtering rules at the application and project levels.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RulesCount : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Client App Rule Counts for all applications in the project</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.X.OpenApiClient.Models.AppRulesCount>? AllProjectClientApps { get; set; }
#nullable restore
#else
        public List<global::Soenneker.X.OpenApiClient.Models.AppRulesCount> AllProjectClientApps { get; set; }
#endif
        /// <summary>Cap of number of rules allowed per client application</summary>
        public int? CapPerClientApp { get; set; }
        /// <summary>Cap of number of rules allowed per project</summary>
        public int? CapPerProject { get; set; }
        /// <summary>A count of user-provided stream filtering rules at the client application level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.X.OpenApiClient.Models.AppRulesCount? ClientAppRulesCount { get; set; }
#nullable restore
#else
        public global::Soenneker.X.OpenApiClient.Models.AppRulesCount ClientAppRulesCount { get; set; }
#endif
        /// <summary>Number of rules for project</summary>
        public int? ProjectRulesCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.X.OpenApiClient.Models.RulesCount"/> and sets the default values.
        /// </summary>
        public RulesCount()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.X.OpenApiClient.Models.RulesCount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.X.OpenApiClient.Models.RulesCount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.X.OpenApiClient.Models.RulesCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "all_project_client_apps", n => { AllProjectClientApps = n.GetCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.AppRulesCount>(global::Soenneker.X.OpenApiClient.Models.AppRulesCount.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cap_per_client_app", n => { CapPerClientApp = n.GetIntValue(); } },
                { "cap_per_project", n => { CapPerProject = n.GetIntValue(); } },
                { "client_app_rules_count", n => { ClientAppRulesCount = n.GetObjectValue<global::Soenneker.X.OpenApiClient.Models.AppRulesCount>(global::Soenneker.X.OpenApiClient.Models.AppRulesCount.CreateFromDiscriminatorValue); } },
                { "project_rules_count", n => { ProjectRulesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.X.OpenApiClient.Models.AppRulesCount>("all_project_client_apps", AllProjectClientApps);
            writer.WriteIntValue("cap_per_client_app", CapPerClientApp);
            writer.WriteIntValue("cap_per_project", CapPerProject);
            writer.WriteObjectValue<global::Soenneker.X.OpenApiClient.Models.AppRulesCount>("client_app_rules_count", ClientAppRulesCount);
            writer.WriteIntValue("project_rules_count", ProjectRulesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

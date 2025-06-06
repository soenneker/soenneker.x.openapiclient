// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.X.OpenApiClient.Models
{
    /// <summary>Status of a compliance job.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ComplianceJobStatus
    {
        [EnumMember(Value = "created")]
        #pragma warning disable CS1591
        Created,
        #pragma warning restore CS1591
        [EnumMember(Value = "in_progress")]
        #pragma warning disable CS1591
        In_progress,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "complete")]
        #pragma warning disable CS1591
        Complete,
        #pragma warning restore CS1591
        [EnumMember(Value = "expired")]
        #pragma warning disable CS1591
        Expired,
        #pragma warning restore CS1591
    }
}


#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Payload Phoenix stamps under the ``phoenix`` namespace of Vercel AI<br/>
    /// ``providerMetadata`` on tool-call chunks (``tool-input-start`` and<br/>
    /// ``tool-input-available``).
    /// </summary>
    public sealed partial class PhoenixToolCallProviderMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolExecutionEnvironment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PhoenixToolCallProviderMetadataToolExecutionEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PhoenixToolCallProviderMetadataToolExecutionEnvironment ToolExecutionEnvironment { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolInputEmittedAt")]
        public string? ToolInputEmittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixToolCallProviderMetadata" /> class.
        /// </summary>
        /// <param name="toolExecutionEnvironment"></param>
        /// <param name="toolInputEmittedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoenixToolCallProviderMetadata(
            global::Phoenix.PhoenixToolCallProviderMetadataToolExecutionEnvironment toolExecutionEnvironment,
            string? toolInputEmittedAt)
        {
            this.ToolExecutionEnvironment = toolExecutionEnvironment;
            this.ToolInputEmittedAt = toolInputEmittedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixToolCallProviderMetadata" /> class.
        /// </summary>
        public PhoenixToolCallProviderMetadata()
        {
        }

    }
}
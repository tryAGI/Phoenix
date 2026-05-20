
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Payload Phoenix stamps under the ``phoenix`` namespace of Vercel AI<br/>
    /// ``providerMetadata`` on tool-call chunks (``tool-input-start`` and<br/>
    /// ``tool-input-available``).
    /// </summary>
    public sealed partial class ToolCallProviderMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_execution_environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.ToolCallProviderMetadataToolExecutionEnvironment ToolExecutionEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallProviderMetadata" /> class.
        /// </summary>
        /// <param name="toolExecutionEnvironment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallProviderMetadata(
            global::Phoenix.ToolCallProviderMetadataToolExecutionEnvironment toolExecutionEnvironment)
        {
            this.ToolExecutionEnvironment = toolExecutionEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallProviderMetadata" /> class.
        /// </summary>
        public ToolCallProviderMetadata()
        {
        }

    }
}

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Shape of the ``phoenix`` namespace the browser returns in<br/>
    /// ``callProviderMetadata`` on resolved tool parts: the server-stamped fields<br/>
    /// plus browser-recorded execution timings.
    /// </summary>
    public sealed partial class ToolCallCallbackProviderMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_execution_environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ToolCallCallbackProviderMetadataToolExecutionEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.ToolCallCallbackProviderMetadataToolExecutionEnvironment ToolExecutionEnvironment { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_input_emitted_at")]
        public string? ToolInputEmittedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_started_at")]
        public string? ClientStartedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_ended_at")]
        public string? ClientEndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallCallbackProviderMetadata" /> class.
        /// </summary>
        /// <param name="toolExecutionEnvironment"></param>
        /// <param name="toolInputEmittedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientStartedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientEndedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallCallbackProviderMetadata(
            global::Phoenix.ToolCallCallbackProviderMetadataToolExecutionEnvironment toolExecutionEnvironment,
            string? toolInputEmittedAt,
            string? clientStartedAt,
            string? clientEndedAt)
        {
            this.ToolExecutionEnvironment = toolExecutionEnvironment;
            this.ToolInputEmittedAt = toolInputEmittedAt;
            this.ClientStartedAt = clientStartedAt;
            this.ClientEndedAt = clientEndedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallCallbackProviderMetadata" /> class.
        /// </summary>
        public ToolCallCallbackProviderMetadata()
        {
        }

    }
}
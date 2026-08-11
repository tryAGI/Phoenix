
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Shape of the ``phoenix`` namespace the browser returns in<br/>
    /// ``callProviderMetadata`` on resolved tool parts: the server-stamped fields<br/>
    /// plus browser-recorded execution timings.
    /// </summary>
    public sealed partial class PhoenixToolCallCallbackProviderMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolExecutionEnvironment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment ToolExecutionEnvironment { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolInputEmittedAt")]
        public string? ToolInputEmittedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientStartedAt")]
        public string? ClientStartedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientEndedAt")]
        public string? ClientEndedAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public string? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixToolCallCallbackProviderMetadata" /> class.
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
        /// <param name="outcome">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoenixToolCallCallbackProviderMetadata(
            global::Phoenix.PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment toolExecutionEnvironment,
            string? toolInputEmittedAt,
            string? clientStartedAt,
            string? clientEndedAt,
            string? outcome)
        {
            this.ToolExecutionEnvironment = toolExecutionEnvironment;
            this.ToolInputEmittedAt = toolInputEmittedAt;
            this.ClientStartedAt = clientStartedAt;
            this.ClientEndedAt = clientEndedAt;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixToolCallCallbackProviderMetadata" /> class.
        /// </summary>
        public PhoenixToolCallCallbackProviderMetadata()
        {
        }

    }
}
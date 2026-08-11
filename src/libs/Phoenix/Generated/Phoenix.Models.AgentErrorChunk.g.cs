
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Durable data part paired with a standard protocol ``error`` chunk.<br/>
    /// Standard ``error`` chunks are transient: the reducer routes them to error<br/>
    /// callbacks without adding a message part, so they vanish from persisted<br/>
    /// transcripts. Pairing each one with this ``data-error`` part records the<br/>
    /// error durably in the message for persistence, reload, and subagents.
    /// </summary>
    public sealed partial class AgentErrorChunk
    {
        /// <summary>
        /// Default Value: data-error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Payload of the durable ``data-error`` part persisted for protocol errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentErrorData Data { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient")]
        public bool? Transient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorChunk" /> class.
        /// </summary>
        /// <param name="data">
        /// Payload of the durable ``data-error`` part persisted for protocol errors.
        /// </param>
        /// <param name="type">
        /// Default Value: data-error
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="transient">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentErrorChunk(
            global::Phoenix.AgentErrorData data,
            string? type,
            string? id,
            bool? transient)
        {
            this.Type = type;
            this.Id = id;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Transient = transient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorChunk" /> class.
        /// </summary>
        public AgentErrorChunk()
        {
        }

    }
}
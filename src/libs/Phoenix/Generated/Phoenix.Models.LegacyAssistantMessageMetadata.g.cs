
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Legacy transcripts predate the ``type`` discriminator, so default it here.
    /// </summary>
    public sealed partial class LegacyAssistantMessageMetadata
    {
        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnTraceContext")]
        public global::Phoenix.TurnTraceContext? TurnTraceContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Phoenix.AssistantMessageMetadataUsage? Usage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupted")]
        public bool? Interrupted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAssistantMessageMetadata" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="type">
        /// Default Value: assistant
        /// </param>
        /// <param name="turnTraceContext"></param>
        /// <param name="usage"></param>
        /// <param name="interrupted">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyAssistantMessageMetadata(
            string sessionId,
            string? type,
            global::Phoenix.TurnTraceContext? turnTraceContext,
            global::Phoenix.AssistantMessageMetadataUsage? usage,
            bool? interrupted)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnTraceContext = turnTraceContext;
            this.Usage = usage;
            this.Interrupted = interrupted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAssistantMessageMetadata" /> class.
        /// </summary>
        public LegacyAssistantMessageMetadata()
        {
        }

    }
}
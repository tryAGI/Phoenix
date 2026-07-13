
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Wire schema for the chat stream's `message_metadata` payload.
    /// </summary>
    public sealed partial class AssistantMessageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::Phoenix.AssistantMessageMetadataTraceIds? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnTraceContext")]
        public global::Phoenix.TurnTraceContext? TurnTraceContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Phoenix.AssistantMessageMetadataUsage2? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadata" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="trace"></param>
        /// <param name="turnTraceContext"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadata(
            string sessionId,
            global::Phoenix.AssistantMessageMetadataTraceIds? trace,
            global::Phoenix.TurnTraceContext? turnTraceContext,
            global::Phoenix.AssistantMessageMetadataUsage2? usage)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Trace = trace;
            this.TurnTraceContext = turnTraceContext;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadata" /> class.
        /// </summary>
        public AssistantMessageMetadata()
        {
        }

    }
}
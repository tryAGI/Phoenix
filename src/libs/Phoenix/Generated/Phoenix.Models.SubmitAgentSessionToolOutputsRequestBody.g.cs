
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Persist resolved client tool outputs without continuing the turn.
    /// </summary>
    public sealed partial class SubmitAgentSessionToolOutputsRequestBody
    {
        /// <summary>
        /// Client tool results for pending calls on the trailing assistant message, matched by ``toolCallId``. Resending a persisted output verbatim is a no-op; an output that differs from the persisted result or matches no call is rejected with HTTP 409 and code ``agent_session_tool_outputs_conflict``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolOutputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>> ToolOutputs { get; set; }

        /// <summary>
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolOutputsRequestBody" /> class.
        /// </summary>
        /// <param name="toolOutputs">
        /// Client tool results for pending calls on the trailing assistant message, matched by ``toolCallId``. Resending a persisted output verbatim is a no-op; an output that differs from the persisted result or matches no call is rejected with HTTP 409 and code ``agent_session_tool_outputs_conflict``.
        /// </param>
        /// <param name="lastMessageId">
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitAgentSessionToolOutputsRequestBody(
            global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>> toolOutputs,
            string lastMessageId)
        {
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
            this.LastMessageId = lastMessageId ?? throw new global::System.ArgumentNullException(nameof(lastMessageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolOutputsRequestBody" /> class.
        /// </summary>
        public SubmitAgentSessionToolOutputsRequestBody()
        {
        }

    }
}